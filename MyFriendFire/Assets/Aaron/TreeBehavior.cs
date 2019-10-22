using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour
{
    public GameObject[] SpawnList = new GameObject[5];
    public List<GameObject> objectsCreated = new List<GameObject>();
    public int SpawnCount { get; set; } // property to keep track of spawned objects

    //public int terrainHeight = FindHeight();

    private bool _initColorChange;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpawnCount == 10)
            {
                _initColorChange = true;
                return;
            }
            var objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];
            int x = Random.Range(-10, 10);
            int z = Random.Range(-10, 10);
            var pos = new Vector3(x, 0, z);
            GameObject go = Instantiate(objectToSpawn, pos, Quaternion.identity);

            objectsCreated.Add(go);

            SpawnCount++;
        }

        if (_initColorChange == true)
        {
            _initColorChange = false;

            foreach (var obj in objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            objectsCreated.Clear();

        }
    }
}
