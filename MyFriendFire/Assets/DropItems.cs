using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will cause the gameObject to drop an item when the npc is killed.

public class DropItems : MonoBehaviour
{
    public GameObject itemToDrop;
    IEnumerator PauseBeforeDrop(GameObject itemToDrop)
    {
        yield return new WaitForSeconds(0.05f); // time delay before item drop
        itemToDrop.SetActive(true); // check if item can be dropped
        itemToDrop.transform.parent = null;
        yield return new WaitForSeconds(0.05f);
        //if(itemToDrop.GetComponent<>() != null)
        //{
        //    itemToDrop.GetComponent<Item_Master>().CallEventObjectThrow(); // spawns game object
        //}
    }
}
