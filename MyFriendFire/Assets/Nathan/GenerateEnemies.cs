using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    private int xPos;
    private int zPos;
    private int enemyCount; // running total of specified spawned NPCs
    public int spawnNumber; // number of NPCs to be spawned.
    
    void Start()
    {
        EnemyDrop();
    }

    // spawns enemies within a range
    void EnemyDrop()
    {
        while(enemyCount < spawnNumber)
        {
            xPos = Random.Range(-498, 498); // x position of RandomSpawn range spawn -498 to 498
            zPos = Random.Range(-498, 498); // z position of RandomSpawn range spawn -498 to 498
            Instantiate(theEnemy, new Vector3(xPos, 1.0f, zPos), Quaternion.identity); // instantiates enemies at positions within the random range
            enemyCount += 1;
        }
    }

}
