using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 90; // amount of health
    public GameObject thePlayer;

    // Start is called before the first frame update
    public void Damaged(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(thePlayer); // player die
        }
    }

}
