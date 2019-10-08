using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

public class wolfmovement : MonoBehaviour
{
    Transform player; // ref to players position
    PlayerHealth playerHealth; // ref to player health
    EnemyHealth enemyHealth; // reference to enemies health
    UnityEngine.AI.NavMeshAgent nav; // nav mesh agent reference

    private void Awake()
    {
        // set up references
        player = GameObject.FindGameObjectsWithTagWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

   

    // Update is called once per frame
    void Update()
    {
        // if wolf and player are still alive
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
        nav.SetDestination(PlayerPrefs.position); // set enemy nav mesh to the player
        }
        else
        {
        nav.enabled = false;
        }
    }
}
*/