using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxBehavior : MonoBehaviour
{
    public GameObject playerPosition;
    //Vector3 axPos;
    // Start is called before the first frame update
    //public float xPos = 10f;
    //public float zPos = 10f;
    void Start()
    {
        //axPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = playerPosition.transform.position + Vector3.left * 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPosition.transform.position + Vector3.left * 3.5f;

        /*Debug.Log("player position" + axPos);*/
       
        if (Input.GetKey("return"))
        {
            transform.position = playerPosition.transform.position + Vector3.forward * 3.5f;
            //transform.position = transform.position + new Vector3(xPos, 1, zPos);
            //Debug.Log("enter pressed");
        }

    }
}
