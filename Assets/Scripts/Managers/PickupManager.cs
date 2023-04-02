using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace SurvivalGame
{
    public class PickupManager : MonoBehaviour
    {
        [SerializeField] private float distance = 5f;

        private Camera cam;
        private GameObject currentItem = null;
        public LayerMask layermask_;

        private void Start()
        {
            cam = Camera.main;
        }

        private void Update()
        {
            // Detecting objects
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, distance, layermask_))
            {
                // Finding this item
                currentItem = hit.collider.gameObject;
                if (currentItem != null)
                {               
                    currentItem.GetComponent<Item>().message.EnableText();
                    if (Input.GetMouseButtonDown(1))
                    {
                        ItemObject item = currentItem.GetComponent<ItemObject>();                  
                        if (item == null)
                        {
                            Debug.LogWarning("No item to collect!");
                            return;
                        }
                        else
                        {
                            // Collecting Item
                            item.CollectItem();      
                        }                     
                    }                 
                }               
            }
            else
            {
                if (currentItem != null)
                {
                    currentItem.GetComponent<Item>().message.EnableText();
                    currentItem = null;
                }
            }
        }
    }
}