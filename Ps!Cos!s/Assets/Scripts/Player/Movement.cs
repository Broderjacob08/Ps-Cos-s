using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    bool ElevatorKey = false;

    public bool GetElevatorKey()
    {
        return ElevatorKey;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public AudioSource WalkingNoises;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(0, 0);

        if (Input.GetAxis("Vertical")>0) 
        {
            direction.y = 1;
            GetComponent<Animator>().SetBool("Up", true);
            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
            
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            direction.y = -1;
            GetComponent<Animator>().SetBool("Down", true);
            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
            
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            direction.x = 1;
            GetComponent<Animator>().SetBool("Right", true);

            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            direction.x = -1;
            GetComponent<Animator>().SetBool("Left", true);

            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
        }
        
        if (Input.GetAxis("Vertical") == 0)
        {
            GetComponent<Animator>().SetBool("Up", false);
            GetComponent<Animator>().SetBool("Down", false);

            WalkingNoises.Stop();
        }
        if (Input.GetAxis("Horizontal") == 0) 
        {
            GetComponent<Animator>().SetBool("Right", false);
            GetComponent<Animator>().SetBool("Left", false);

            WalkingNoises.Stop();
        }
        
        rb.linearVelocity = direction*speed;
    }
}
