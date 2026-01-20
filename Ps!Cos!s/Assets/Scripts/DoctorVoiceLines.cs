using UnityEngine;

public class DoctorVoiceLines : MonoBehaviour
{
    private GameObject player;

    public AudioSource Hiding;
    public AudioSource NotNice;
    public AudioSource Mad;

    int SpeechCooldown = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindObjectOfType<Movement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance <= 15)
        {
            if (SpeechCooldown == 2000)
            {
                int RandomVoiceLine = Random.Range(1, 4);

                if (RandomVoiceLine == 1)
                {
                    Hiding.Play();
                }
                if (RandomVoiceLine == 2)
                {
                    NotNice.Play();
                }
                if (RandomVoiceLine == 3)
                {
                    Mad.Play();
                }
            }
        }
        


        SpeechCooldown += 1;
    }
}
