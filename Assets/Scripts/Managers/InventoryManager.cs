using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurvivalGame
{
    public class InventoryManager : MonoBehaviour
    {
        public Inventory inventory;
        public RectTransform container;
        private int size = 6;
        private Slot[] slots;
        static public List<SlotItem> slotsItems = new List<SlotItem>();
        private void Awake()
        {       
            inventory =  GetComponent<Inventory>();
            StartBar();
            UpdateBar();
        }

        private void StartBar()
        {
            slots = new Slot[container.childCount];
        }

        private void UpdateBar()
        {
            if (slotsItems.Count > 0)
            {
                for (int i = 0; i < slotsItems.Count; i++)
                {
                    slots[i].UpdateSlot(slotsItems[i].itemSprite_, false);
                }
            }   
        }
    }
}