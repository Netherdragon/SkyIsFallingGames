using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTreeDistance : MonoBehaviour
{
    // Declare and initialize a new List of GameObjects called currentCollisions.
    //List<GameObject> currentCollisions = new List<GameObject>();

    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }

    /*void OnCollisionExit(Collision col)
    {

        // Remove the GameObject collided with from the list.
        currentCollisions.Remove(col.gameObject);

        // Print the entire list to the console.
        foreach (GameObject gObject in currentCollisions)
        {
            print(gObject.name);
        }
    }*/

    // Collect all colliders within our Obstacle Check Radius
    /*Collider[] colliders = Physics.OverlapSphere(spawnPosition, obstacleCheckRadius);

        // Go through each collider collected
        foreach (Collider col in colliders)
        {
        // If this collider is tagged "Obstacle"
            if (col.tag == "tree" || col.tag == "campground")
            {
                // Then this position is not a valid spawn position
                validPosition = false;
            }
        }*/
}
