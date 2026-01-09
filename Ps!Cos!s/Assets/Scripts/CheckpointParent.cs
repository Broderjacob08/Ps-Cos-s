using UnityEngine;
using System.Collections.Generic;
public class CheckpointParent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> checkpoints = new List<GameObject>();

    int index;

    public int GetIndex()
    {
        return index;
    }

    void Start()
    {
        for(int i = 0; i < gameObject.transform.childCount; i++)
        {
            checkpoints.Add(gameObject.transform.GetChild(i).gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(index >=gameObject.transform.childCount-1)
        {
            index = 0;
        }
    }

    public void SetIndex(int newIndex)
    {
        index = index += newIndex;
    }


}
