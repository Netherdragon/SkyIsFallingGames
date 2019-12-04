using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMeat : DestroyonTrigger
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject); // meat is destroyed
        }
    }

}
