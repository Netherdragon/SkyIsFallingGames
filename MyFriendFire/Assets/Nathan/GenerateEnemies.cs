using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    private int enemyCount;
    // private float spawnTime;
    public int spawnNumber;
    
    void Start()
    {
        EnemyDrop();
    }

    // spawns enemies within a range
    void EnemyDrop()
    {
        while(enemyCount < spawnNumber)
        {
            xPos = Random.Range(-200, 200); // x position of RandomSpawn range
            zPos = Random.Range(-200, 200); // z position of RandomSpawn range
            Instantiate(theEnemy, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
            // yield return new WaitForSeconds(0.01f);
            enemyCount += 1;
        }
    }

}
