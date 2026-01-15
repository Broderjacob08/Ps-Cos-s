using Assets.Scripts;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    //the item the player is holding
    public Item heldItem;

    //the nearest item
    private Item nearbyItem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(heldItem == null && nearbyItem != null)
            {
                PickUpItem(nearbyItem);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(heldItem != null)
            {
                DropItem();
            }
            else if(nearbyItem != null)
            {
                PickUpItem(nearbyItem);
            }
        }
    }

    private void PickUpItem(Item item)
    {
        heldItem = item;
        //disable item visually and physically

        ItemsClass key = item.GetComponent<ItemsClass>();
        if(key != null)
        {
            key.onPickup();
        }

        item.gameObject.SetActive(false);

        Debug.Log("Picked up!: " + item.itemName);
    }

    private void DropItem()
    {
        /*/Vector3 dropPosition = transform.position + Vector3.right;

        heldItem.transform.position = dropPosition;/*/

        //drops item 
        heldItem.transform.position = transform.position;
        heldItem.gameObject.SetActive(true);

        Debug.Log("Dropped!: " + heldItem.itemName);
        
        heldItem = null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (nearbyItem)
        {
            print("is near item");
        }

        Item item = collision.GetComponent<Item>();

        if(item != null)
        {
            nearbyItem = item;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

        if(item != null && item == nearbyItem)
        {
            nearbyItem = null;
        }
    }

}
