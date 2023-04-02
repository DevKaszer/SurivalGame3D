using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SurvivalGame
{
    public class SlotUI : MonoBehaviour
    {
		[SerializeField]
		private bool isEmpty_;
		[SerializeField]
		private TMP_Text QuantityText;

        private void Awake()
        {
            QuantityText.GetComponent<TMP_Text>().text = "0";
        }
        public bool isEmpty	
		{	
			get { return isEmpty_; }
			set { isEmpty_ = value; }
		}
		public void SetSlot(ItemUI item)
		{
			transform.GetChild(0).GetComponent<Image>().sprite = item.itemSprite;
			QuantityText.GetComponent<TMP_Text>().text = "" + item.itemQuantity;
        }
	}
}