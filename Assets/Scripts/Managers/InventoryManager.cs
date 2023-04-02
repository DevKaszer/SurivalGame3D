using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace SurvivalGame
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private SlotUI slotPrefab;
        [SerializeField]    
        private RectTransform container;
        [SerializeField]
        private RectTransform container2;
        private int size = 6;
        public SlotUI[] slots;
        public SlotUI[] slots2;
        // List of listOfUIItems
        public List<ItemUI> listOfUIItems = new List<ItemUI>();
        public void InitializeInventoryUI()
        {
            slots = new SlotUI[size];
            slots2= new SlotUI[18];
            for (int i = 0; i < 18; i++)
            {
                slots2[i] = Instantiate(slotPrefab, Vector3.zero, Quaternion.identity);
                slots2[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                slots2[i].transform.SetParent(container2);
                slots2[i].isEmpty = true;
            }
            for (int i = 0; i < size; i++)
            {
                slots[i] = Instantiate(slotPrefab, Vector3.zero, Quaternion.identity);
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                slots[i].transform.SetParent(container);
                slots[i].isEmpty= true;         
            }
        }

        public void UpdateInventoryUI()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].isEmpty)
                {
                    if (listOfUIItems.Count > 0)
                    {
                        slots[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                        slots[i].SetSlot(listOfUIItems[0]);
                        slots[i].isEmpty = false;
                        break;
                    }
                }
            }                  
        }
        public void AddItemToItems(ItemUI item)
        {
            listOfUIItems.Add(item);
        }
    }
}