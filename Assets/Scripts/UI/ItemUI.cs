using System.Collections;
using UnityEngine;

namespace SurvivalGame
{
    [CreateAssetMenu]
    public class ItemUI : ScriptableObject
    {
        public string itemName;
        public Sprite itemSprite;
        public string itemQuantity;
        public int itemID;
    }
}