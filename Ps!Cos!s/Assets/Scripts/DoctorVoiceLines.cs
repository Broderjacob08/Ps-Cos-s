using UnityEngine;

public class DoctorVoiceLines : MonoBehaviour
{
    public AudioSource Hiding;
    public AudioSource NotNice;
    public AudioSource Mad;

    int SpeechCooldown = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SpeechCooldown == 2000)
        {
            int RandomVoiceLine = Random.Range(1, 4);

            if(RandomVoiceLine == 1)
            {
                Hiding.Play();
            }
            if(RandomVoiceLine == 2)
            {
                NotNice.Play();
            }
            if(RandomVoiceLine == 3)
            {
                Mad.Play();
            }
        }


        SpeechCooldown += 1;
    }
}
