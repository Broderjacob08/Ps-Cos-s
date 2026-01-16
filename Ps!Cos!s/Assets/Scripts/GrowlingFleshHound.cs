using UnityEngine;

public class FleshHoundNoises : MonoBehaviour
{
    public AudioSource Walking;
    public AudioSource Growling;
    int time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(Walking.isPlaying == false)
        {
            Walking.Play();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Walking.enabled = true;
        Growling.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Walking.enabled = false;
        Growling.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Growling.isPlaying == false && time == 1000)
        {
            Growling.Play();
        }


            time += 1;
    }
}
