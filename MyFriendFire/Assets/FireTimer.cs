using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTimer : GrowFire
{
    int FirewoodOnPlayer = GameObject.Find("Player").GetComponent<GatherWood>().numberOfFirewood;
    // Start is called before the first frame update
    int FirewoodOnFire = 5;
    void Start()
    {
        for (int i = FirewoodOnFire; i > 0; i--)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            FirewoodOnFire += FirewoodOnPlayer;
            Debug.Log("This is the number of wood on the campfire: " + FirewoodOnFire);
        }
    }
}
