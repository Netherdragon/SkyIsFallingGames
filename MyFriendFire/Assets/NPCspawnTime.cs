using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCspawnTime : MonoBehaviour
{
    public GameObject Spawner;
    private float spawnTime;
    void Start()
    {
        spawnTime = GetComponent<DayNight>().time;
        if(spawnTime < 21696)
        {
            Spawner.SetActive(true);
        }
        else
        {
            Spawner.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
