/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotController : MonoBehaviour {
	public Item item;

	private void Start()
	{
		updateInfo();
	}

	public void updateInfo()
	{
		Text displayText = transform.Find("Text").GetComponent<Text>();
		Image displayImage = transform.Find("Image").GetComponent<Image>();
	}
	public void Use()
	{
		if (item)
		{
			displayText.text = item.itemName;
			displayImage.sprite = item.icon;
		}
		else
		{
			displayText.text = "";
			displayImage.sprite = null;
		}
	}
}
*/