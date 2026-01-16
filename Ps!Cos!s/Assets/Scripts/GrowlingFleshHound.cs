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

    // Update is called once per frame
    void Update()
    {
        if (Growling.isPlaying == false && time == 500)
        {
            Growling.Play();
        }


            time += 1;
    }
}
