using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int startpositionx;
    int startpositiony;

    CheckpointParent checkpointHolder;
    
    void Start()
    {
        transform.position = new Vector3(startpositionx, startpositiony, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = checkpointHolder.checkpoints[checkpointHolder.GetIndex()].transform.position-transform.position;
    }
}
