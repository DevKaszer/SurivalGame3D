using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace SurvivalGame
{
    public class DisplayMessage : MonoBehaviour
    {
        [SerializeField] private string message;
        [SerializeField] private TextMeshProUGUI messageText; 
        private Camera Cam_;
        private void OnValidate()
        {
            messageText.text = message;
        }
        private void Awake()
        {
            Cam_ = Camera.main;
        }
        private void LateUpdate()
        {
            transform.rotation = Quaternion.LookRotation(transform.position - Cam_.transform.position);
        }

        public void SetMessageText(string mess)
        {
            messageText.text = ("Right Mouse - " + mess);
        }

        public void EnableText()
        {
           gameObject.SetActive(true);
        }

        public void DisableText()
        {
            gameObject.SetActive(false);
        }
    }
}