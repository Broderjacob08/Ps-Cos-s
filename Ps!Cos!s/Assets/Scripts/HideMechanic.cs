using UnityEngine;

public class HideMechanic : MonoBehaviour
{

    bool PlayerCanHIde = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerCanHIde == true && Input.GetKeyDown(KeyCode.H) && gameObject.layer != LayerMask.NameToLayer("Hidden"))
        {
            gameObject.layer = LayerMask.NameToLayer("Hidden");

            print("Hidden");
        }
        else if(gameObject.layer == LayerMask.NameToLayer("Hidden") && Input.GetKeyDown(KeyCode.H))
        {
            gameObject.layer = LayerMask.NameToLayer("Default");

            print("Unhidden");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "HideSpot")
        {
            PlayerCanHIde = true;
        }

        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "HideSpot")
        {
            PlayerCanHIde = false;

            gameObject.layer = LayerMask.NameToLayer("Default");

            print("Unhidden");
        }


    }
}
