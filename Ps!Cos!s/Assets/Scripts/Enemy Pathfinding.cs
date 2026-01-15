using UnityEngine;
using System.Collections.Generic;
public class EnemyPathfinding : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    
    //Startvalues for positioning + the empty needed for pathfinding
    
    
    [SerializeField] float speed;

    bool chasingplayer;

    [SerializeField] CheckpointParent checkpointHolder;
    [SerializeField] Movement player;

    Rigidbody2D rb;
    Vector3 chasing;
    
    void Start()
    {
        chasingplayer = false;
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(checkpointHolder.GetIndex());
        if (chasingplayer == false)
        {
            SetChasing(checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position);
        } else
        {
            SetChasing(player.transform.position);
        }

        transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.right, rb.linearVelocity));
        rb.linearVelocity = (chasing - transform.position).normalized * speed;
        
    }

    void SetChasePlayer(bool huntmode)
    {
        chasingplayer = huntmode;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SetChasePlayer(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SetChasePlayer(false);
        }
    }

    void SetChasing(Vector3 currentlychasing)
    {
        chasing = currentlychasing;
    }
}
