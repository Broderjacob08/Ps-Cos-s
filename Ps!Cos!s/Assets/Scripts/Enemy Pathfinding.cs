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
        print("kört start");
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(startpositionx, startpositiony, startpositionz);
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = (checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position - transform.position).normalized * speed;
    }
}
