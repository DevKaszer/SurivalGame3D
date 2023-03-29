using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace SurvivalGame
{
    public class Slot : MonoBehaviour
    {
        private Image image = null;
        public bool isEmpty;

        public void UpdateSlot(Sprite itemSprite_, bool empty_)
        {
            image.sprite = SetSprite(itemSprite_);
            isEmpty = empty_;
        }

        public Sprite SetSprite(Sprite imageSprite)
        {
            Sprite sprite_ = null;
            if (image != null)
                sprite_ = imageSprite;    
            return sprite_;
        }
    }
}