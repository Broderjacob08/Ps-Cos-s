using Assets.Scripts;
using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public string requiredKey = "ExitDoor";
    private bool playerIsNear = false;
    private PlayerPickUp playerScript;

    void Update()
    {
        
        /*/if(playerIsNear && Input.GetKeyDown(KeyCode.E))
        {
            TryOpenDoor();
        }

        void TryOpenDoor()
        {
            if(playerScript.heldItem != null)
            {
                ItemsClass heldKey = playerScript.heldItem.GetComponent<ItemsClass>();
                if(heldKey != null && heldKey.key == requiredKey)
                {
                    Open();
                }
            }
        }
        
        void Open()
        {
            Debug.Log("door opens");

            GetComponent<BoxCollider2D>().enabled = false;

            //removes item after you use it
            playerScript.heldItem = null;

            gameObject.SetActive(false);
        }/*/

        

        
    }
}
