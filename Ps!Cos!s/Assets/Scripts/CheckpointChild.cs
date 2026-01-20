using UnityEditor;
using UnityEngine;

public class CheckpointChild : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    CheckpointParent parentObject;

    void Start()
    {
        parentObject = transform.parent.GetComponentInParent<CheckpointParent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            parentObject.SetIndex();
            print(collision.gameObject.name + " " + parentObject.GetIndex());
        }
    }

}
