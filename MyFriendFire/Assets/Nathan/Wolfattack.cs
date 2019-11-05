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
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("A wolf attacked you");
            health--;
            Debug.Log("health: " + health);
        }
    }

    private void Update()
    {
        if(health <= 0)
        {
            // do something

        }
    }

}
