using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script to allow trees to be cut down and produce firewood
public class TreeBehavior : MonoBehaviour
{
    private int treeHealth = 2;
    public GameObject wood;
    //public GameObject player;

    private void Start()
    {
        // needs a character to 
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {

        // detects if player in range
        if (other.gameObject.name == "GamePlayer")
        {
            treeHealth -= 1;
            Debug.Log("health: " + treeHealth);
        }
    }

    private void Update()
    {
        // once health gets to zero start code to spawn firewoood and destroy old tree clone
        if (treeHealth <= 0)
        {
            Debug.Log("chopped down");
            giveFirewood();
        }
    }

    void giveFirewood()
    {
        // spawns piece of wood and destroys tree model
        GameObject woodClone = (GameObject)Instantiate(wood, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
