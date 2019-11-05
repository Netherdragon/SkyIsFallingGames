/*using UnityEngine;

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;
	public GameObject inventoryUI;
	Inventory inventory;

	inventorySlot[] slots;

	void Start () {
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;

		slots = itemParent.GetComponetsInChildren<InventorySlot>();
	}

	void Update () 
	{
		if (Input.GetButtonDown("Inventory"))
		{
			inventoryUI.SetActive(!inventoryUI.activeSelf);
		}
	}

	void UpdateUI () 
	{
		for (int i = 0; i < slots.Length;; i++)
		{
			if (i < inventory.items.Count)
			(
				slots[i].AddItem(Inventory.items[i]);
			) else
			{
				slots[i].ClearSlot();
			}
		}
	}
}
*/