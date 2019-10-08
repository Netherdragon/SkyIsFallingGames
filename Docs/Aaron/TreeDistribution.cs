using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class TreeDistribution : MonoBehaviour {
    public GameObject trees;
    public Vector3 center;
    public Vector3 size;

    public void SpawnTrees() {
        Vector3 pos = center + new Vector3(UnityEngine.Random.Range(-size.x/2, size.x/2), 1f, UnityEngine.Random.Range(-size.z/2, size.z/2));
        Instantiate(trees, pos, Quaternion.identity);
        
    }

    
}


