using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace SurvivalGame
{
    public class MouseInteract : MonoBehaviour
    {
        [SerializeField] private float distance = 2f;

        private Camera cam;
        private GameObject item = null;
        public LayerMask layermask_;

        private void Start()
        {
            cam = Camera.main;
        }

        private void Update()
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, distance, layermask_))
            {
                Item item_ = hit.collider.GetComponent<Item>();
                if (item_)
                    item = item_.gameObject;
                    //item_.message.EnableText();
                if (Input.GetMouseButtonDown(1) && item_)            
                    CollectItem(item.GetComponent<Item>());      
            }
            else
            {
                if (item != null)
                {
                    //item.GetComponent<Item>().message.DisableText();
                }      
            }
        }

        private void CollectItem(Item item_)
        {
            Inventory inventory = FindObjectOfType<Inventory>(); 

            if (inventory != null)
            {
                inventory.AddItem(item_);
                inventory.UpdateInventory();
                Destroy(item_);
                item = null;
            }   
            else
            {   
                Debug.LogWarning("Inventory not found!");
            }
        }
    }
}