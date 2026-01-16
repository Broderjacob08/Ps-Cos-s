using UnityEngine;
using System.Collections.Generic;
public class Flashlight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    bool power;

    SpriteRenderer sprite;
    SpriteRenderer lightbeam;
    Rigidbody2D playermovement;
    [SerializeField] GameObject Light;
    Transform parent;

    [SerializeField] Sprite on;
    [SerializeField] Sprite off;

    [SerializeField] float lightsizex;
    [SerializeField] float lightsizey;
    [SerializeField] float lightposition;
    void Start()
    {
        power = false;
        sprite = GetComponent<SpriteRenderer>();
        lightbeam = Light.GetComponent<SpriteRenderer>();
        playermovement = GetComponentInParent<Rigidbody2D>();
        parent = GetComponentInParent<Transform>();
        transform.position = new Vector3(transform.position.x, transform.position.y, parent.position.z - 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            SetOnOrOff(!power);
        }
        
        
        if (power == true)
        {
            sprite.sprite = on;
            lightbeam.enabled = true;
        }else
        {
            sprite.sprite = off;
            lightbeam.enabled = false;
        }

        transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.right, playermovement.linearVelocity));
        Light.transform.localScale = new Vector3(lightsizex,lightsizey,Light.transform.localScale.z);
        Light.transform.localPosition = new Vector3(lightposition, Light.transform.localPosition.y, Light.transform.localPosition.z);
        
    }

    void SetOnOrOff(bool onoroff)
    {
        power = onoroff;
    }
}
