using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTrigger : MonoBehaviour
{
    public GameObject objToDestroy;

    // function to destroy game objects that get too close to the campfire
    void onTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy") // obj specified as enemy
        {
            Destroy(objToDestroy); // destroy enemy
        }
    }
}
