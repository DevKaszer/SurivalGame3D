using System.Collections;
using UnityEngine;

namespace SurvivalGame
{
    public class PlayerUI : MonoBehaviour
    {
        public GameObject Inventorysx;
        public GameObject CursorTexture;
        public bool isShowed;
        private void Awake()
        {
            isShowed = false;
            Hide();
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (Inventorysx.activeInHierarchy == false)
                {
                    Show();
                }
                else
                {
                    Hide();
                }
            }
        }
        public void Show()
        {
            Inventorysx?.gameObject.SetActive(true);
            CursorTexture?.gameObject.SetActive(false);
            isShowed= true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void Hide()
        {
            Inventorysx?.gameObject.SetActive(false);
            CursorTexture?.gameObject.SetActive(true);
            isShowed = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}