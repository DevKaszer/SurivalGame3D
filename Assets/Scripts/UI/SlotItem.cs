using System.Collections;
using UnityEngine;

namespace SurvivalGame
{
    public class SlotItem : MonoBehaviour
    {
        public Sprite itemSprite_;
        public SlotItem(Sprite itemSprite_)
        {
            this.itemSprite_ = itemSprite_;
        }
    }
}