using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject Prefab;
    public int numRabbits;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        for (int i = 0; i < numRabbits; i++)
        {
            Instantiate(Prefab, spawnPoint.position, spawnPoint.rotation);
            
        }
    }

}
