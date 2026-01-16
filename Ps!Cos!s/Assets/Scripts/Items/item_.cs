using UnityEngine;

public class item_ : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public class Item : MonoBehaviour
    {
        public enum ItemType
        {
            key,
            keycard
        }

        public ItemType itemType;

        public string itemName;


    }
}
