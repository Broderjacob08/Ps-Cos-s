using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class FleshHoundNoises : MonoBehaviour
{
    private GameObject player;
    public AudioSource Walking;
    public AudioSource Growling;
    int time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindObjectOfType<Movement>().gameObject;
        if(Walking.isPlaying == false)
        {
            Walking.Play();
        }
        
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Walking.enabled = true;
        Growling.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Walking.enabled = false;
        Growling.enabled = false;
    }*/

    // Update is called once per frame
    void Update()
    {
        time += 1;

        

        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance <= 13)
        {
            Walking.enabled = true;
            Growling.enabled = true;
            if(Walking.isPlaying == false)
            {
                Walking.Play();
            }
            
            if (Growling.isPlaying == false && time >= 1000)
            {
                Growling.Play();
                time = 0;
            }
        }
        else
        {
            Walking.enabled = false;
            Growling.enabled = false;
        }
    }
}
