using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnflower : MonoBehaviour
{
// keeps flowers from spawning to close to each other

    public GameObject[] trees;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    //public GameObject ground;
    int maxSpawnAttemptsPerTree = 3;
    float obstacleCheckRadius = 3f;
    public int treeNum = 0;

    private int randTree;
    void Start()
    {

        StartCoroutine(waitToGrow());
    }


    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitToGrow()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)//(GameObject.FindGameObjectsWithTag("tree").Length < 500)
        {
            randTree = Random.Range(0, 1);

            Vector3 spawnPosition = Vector3.zero; // new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1.5f, Random.Range(-spawnValues.z, spawnValues.z));

            bool validPosition = false;

            // How many times we've attempted to spawn this obstacle
            int spawnAttempts = 0;

            // havent found a valid position yet && haven't used up attempts
            while (!validPosition && spawnAttempts < maxSpawnAttemptsPerTree)
            {
                // Increment number of attempts
                spawnAttempts++;

                // Pick a random position
                spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 0, Random.Range(-spawnValues.z, spawnValues.z));
                //Debug.Log("1st spawnValues: " + spawnValues.x + "  " + spawnValues.z);
                // This position is valid until proven invalid
                validPosition = true;

                // Collect all colliders within our Obstacle Check Radius
                Collider[] colliders = Physics.OverlapSphere(spawnPosition, obstacleCheckRadius);

                // Go through each collider collected
                foreach (Collider col in colliders)
                {
                    // If the collider is out of bounds like a tree or the center of the map
                    if (col.tag == "tree" || col.tag == "campground")
                    {
                        // Then this position is not a valid spawn position
                        validPosition = false;
                    }
                }
            }

            // If we exited the loop with a valid position
            if (validPosition)
            {
                //Vector3 pos = GameObject.FindWithTag("ground").transform.position;
                //pos.y = Terrain.activeTerrain.SampleHeight(spawnPosition);
                //transform.position = pos;
                //float height = pos.y;
                Instantiate(trees[randTree], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                treeNum++;
            }
            yield return new WaitForSeconds(spawnWait);
        }

    }
}

