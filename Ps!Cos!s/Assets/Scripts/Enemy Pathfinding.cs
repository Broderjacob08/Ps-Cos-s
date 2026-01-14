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

    bool chasingplayer;

    [SerializeField] CheckpointParent checkpointHolder;
    [SerializeField] Movement player;

    //public EnemyPathfinding(CheckpointParent checkpointHolder) 
    //{
      //  this.checkpointHolder = checkpointHolder;
    //}

    Rigidbody2D rb;
    
    void Start()
    {
        chasingplayer = false;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(startpositionx, startpositiony, startpositionz);
    }

    // Update is called once per frame
    void Update()
    {
        if(chasingplayer == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, rb.linearVelocity));
            rb.linearVelocity = (checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position - transform.position).normalized * speed;
        } else
        {
            transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, rb.linearVelocity));
            rb.linearVelocity = (player.transform.position - transform.position).normalized * speed;
        }
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
}
