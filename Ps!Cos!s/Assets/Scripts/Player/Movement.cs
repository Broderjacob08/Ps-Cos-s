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
        rb.linearVelocity = new Vector2(0,0);
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(0, 1) * speed;

            GetComponent<Animator>().SetBool("Up", true);
            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(0, -1) * speed;

            GetComponent<Animator>().SetBool("Down", true);
            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(1, 0) * speed;

            GetComponent<Animator>().SetBool("Right", true);

            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-1, 0) * speed;

            GetComponent<Animator>().SetBool("Left", true);

            if(WalkingNoises.isPlaying == false)
            {
                WalkingNoises.Play();
            }
        }
        if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(-1, 1) * speed;
        }

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(1, 1) * speed;
        }
        if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(1, -1) * speed;
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-1, -1) * speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(0, 1) * speed;

            GetComponent<Animator>().SetBool("Up", false);

            WalkingNoises.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(0, -1) * speed;

            GetComponent<Animator>().SetBool("Down", false);

            WalkingNoises.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(1, 0) * speed;

            GetComponent<Animator>().SetBool("Right", false);

            WalkingNoises.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-1, 0) * speed;

            GetComponent<Animator>().SetBool("Left", false);

            WalkingNoises.Stop();
        }
    }
}
