using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurvivalGame
{
    public class GameManager : MonoBehaviour
    {
        public Inventory inventory { get; private set; }
        public static GameManager instance;
        private void Awake()
        {
            inventory = FindObjectOfType<Inventory>();
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
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}