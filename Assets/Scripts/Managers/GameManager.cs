using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace SurvivalGame
{
    public class GameManager : MonoBehaviour
    {
        public InventoryManager inventory;
        public static GameManager instance;
        private void Awake()
        {
            inventory = FindObjectOfType<InventoryManager>();
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            inventory.InitializeInventoryUI();
        }
    }
}