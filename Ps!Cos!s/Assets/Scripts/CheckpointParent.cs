using UnityEngine;
using System.Collections.Generic;
public class CheckpointParent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> checkpoints = new List<GameObject>();

    int index;

    bool goforward;

    [SerializeField] bool goInCircles;

    public int GetIndex()
    {
        return index;
    }

    void Start()
    {
        index = 0;

        goforward = true;

        for(int i = 0; i < gameObject.transform.childCount; i++)
        {
            checkpoints.Add(gameObject.transform.GetChild(i).gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void SetIndex()
    {
        if(goforward == true)
        {
            index += 1;
        }else if (goforward == false)
        {
            index -= 1;
        }

        if (goInCircles == true)
        {
            if (index >= gameObject.transform.childCount)
            {
                index = 0;
            }
        }
        else if (goInCircles == false)
        {
            if (index >= gameObject.transform.childCount - 1)
            {
                SetGoForward(false);
            }
            if (index <= 0)
            {
                SetGoForward(true);
            }
        }
    }

    void SetGoForward(bool direction)
    {
        goforward = direction;
    }
}
