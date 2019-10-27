using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GatherWood : MonoBehaviour
{
    public bool haveItem = false;
    

    public GameObject playerPosition;
    public GameObject firePosition;
    public GameObject campground;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.SetActive(false);
            haveItem = true;
            
        }
    }

    private void Update()
    {
        Debug.Log("haveItem: " + haveItem);

        if (Input.GetKey("right shift"))
        {
            transform.position = firePosition.transform.position;
        }
    }

    /*public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "wood")
        {
            haveItem = true;
        }
    }*/


}
