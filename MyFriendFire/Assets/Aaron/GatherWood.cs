using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a script to pick up the firewood that is dropped when a tree is chopped down
public class GatherWood : MonoBehaviour
{
    public int numberOfFirewood = 0;

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "firewood")
        {
            // can collect an infinte number of wood 
            numberOfFirewood++;
            Destroy(collision.gameObject);
            Debug.Log("number of pieces: " + numberOfFirewood);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "firewood")
        {
            // can collect an infinte number of wood 
            numberOfFirewood++;
            Destroy(other.gameObject);
            Debug.Log("number of pieces: " + numberOfFirewood);
        }
    }
}
