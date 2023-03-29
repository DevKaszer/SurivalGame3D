using System.Collections;
using UnityEngine;

namespace SurvivalGame
{
    public class Item : MonoBehaviour
    {
        public Sprite imgSprite_ = null;
        public string name_ = "";    
        public DisplayMessage message;  

        private void Start()
        {
            message.SetMessageText(name_);
        }
    }
}