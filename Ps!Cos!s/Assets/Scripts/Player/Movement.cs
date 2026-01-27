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
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
        {
            direction.y = -1;
            GetComponent<Animator>().SetBool("Down", true);
            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
            
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction.x = 1;
            GetComponent<Animator>().SetBool("Right", true);

            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x = -1;
            GetComponent<Animator>().SetBool("Left", true);

            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
        }
        
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            GetComponent<Animator>().SetBool("Up", false);

            WalkingNoises.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            GetComponent<Animator>().SetBool("Down", false);

            WalkingNoises.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("Right", false);

            WalkingNoises.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetBool("Left", false);

            WalkingNoises.Stop();
        }
        
        rb.linearVelocity = direction*speed;
    }
}
