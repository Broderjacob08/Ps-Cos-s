using UnityEngine;
using System.Collections.Generic;
public class EnemyPathfinding : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    
    //Startvalues for positioning + the empty needed for pathfinding
    
    [SerializeField] float startpositionx;
    [SerializeField] float startpositiony;
    [SerializeField] float startpositionz;
    [SerializeField] float speed;

    [SerializeField] CheckpointParent checkpointHolder;

    //public EnemyPathfinding(CheckpointParent checkpointHolder) 
    //{
      //  this.checkpointHolder = checkpointHolder;
    //}

    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(startpositionx, startpositiony, startpositionz);
        rb.linearVelocity = (checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.magnitude <= 0)
        {
            rb.linearVelocity = rb.linearVelocity.normalized;
        }
        else
        {
            rb.linearVelocity = (checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position - transform.position).normalized * speed;
        }
        //Checks velocity
        Debug.Log("Velocity: " + rb.linearVelocity);
    }
}
