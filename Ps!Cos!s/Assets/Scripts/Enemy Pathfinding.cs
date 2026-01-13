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
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, rb.linearVelocity));
        rb.linearVelocity = (checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position - transform.position).normalized * speed;
    }
}
