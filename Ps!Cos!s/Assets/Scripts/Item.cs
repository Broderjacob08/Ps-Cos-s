using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        key,
        keycard,
        other
    }

    public ItemType itemType;

    //debug later
    public string itemName;
}
