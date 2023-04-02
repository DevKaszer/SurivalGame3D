using System.Collections;
using UnityEngine;

namespace SurvivalGame
{
    public class Item : MonoBehaviour, ItemObject
    {
        [Header("Drops")]
        public ItemUI itemUI;
        [Header("Settings")]
        public DisplayMessage message; 

        private void Start()
        {
            if(message != null)
                message.SetMessageText(itemUI.itemName);
        }

        public void CollectItem()
        {
            GameManager.instance.inventory.AddItemToItems(itemUI);
            GameManager.instance.inventory.UpdateInventoryUI();
            if (GameManager.instance.inventory == null)
            {
                Debug.LogWarning("Inventory not found!");
            }
            Destroy(gameObject);
        }
    }
}