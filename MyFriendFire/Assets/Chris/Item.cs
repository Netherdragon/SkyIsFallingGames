using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
pubic class Item : ScriptableObject {
	new pubic string name = "New Item";
	pubic Sprite icon = null;
	pubic bool isDefaultItem = false;

	pubic virtual void Use ()
	{
		Debug.Log("Using " + name);
	}
}