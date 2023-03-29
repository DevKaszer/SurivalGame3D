using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace SurvivalGame
{
    [CreateAssetMenu]
    public class Inventory : MonoBehaviour
    {
        static public List<Item> items = new List<Item>();
        private void Start()
        {        
            UpdateInventory();          
        }
        public void UpdateInventory()
        {
            if (items.Count > 0)
            {
                foreach (Item item in items)
                {
                    InventoryManager.slotsItems.Add(new SlotItem(item.imgSprite_));                                   
                }                                  
            }
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

    }
}