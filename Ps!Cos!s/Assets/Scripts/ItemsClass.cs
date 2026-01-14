using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class ItemsClass : Item
    {
        //public string key = "ExitDoor";

        public GameObject door;
        private bool isPickedUp = false;

        public void onPickup()
        {
            isPickedUp = true;
            Debug.Log("keyyy");

            if(door != null)
            {
                door.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
