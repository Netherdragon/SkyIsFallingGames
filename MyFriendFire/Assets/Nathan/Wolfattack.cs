using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wolfattack : MonoBehaviour
{
    public int health = 5;

    void Start()
    {

    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(other.gameObject.tag == "Enemy") // enemy tag collides with player
        {
            Debug.Log("A wolf attacked you");
            health--; // causes player to lose health
            Manager.instance.HP = health; // manager HP tied to health
            Debug.Log("health: " + health);
        }

        else if (other.gameObject.tag == "Meat") // meat tag collides with player
        {
            Debug.Log("You ate some meat");
            health++; // health increase
            if(health >= 10)
            {
                health = 10;
                Manager.instance.HP = 10;
            }
            Manager.instance.AddHealth(); // Game manager gains HP 
            Debug.Log("health " + health);
       
        }
    }


    private void Update()
    {
        if(health <= 0)
        {
            if (Manager.instance.HP == 0)
                Destroy(gameObject); // If health is 0, this script destroys 

        }
    }

}
