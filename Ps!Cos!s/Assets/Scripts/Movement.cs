using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.5f;
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

    // Update is called once per frame
    void Update()
    {

        rb.linearVelocity = new Vector2(0,0);
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(0, 1) * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(0, -1) * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(1, 0) * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-1, 0) * speed;
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

    }
}
