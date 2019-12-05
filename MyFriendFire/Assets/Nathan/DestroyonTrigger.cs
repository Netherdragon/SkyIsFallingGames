using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTrigger : MonoBehaviour
{

    public GameObject Meat;
    private bool rabbitIsAlive = true;

    public virtual void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") // player tag collides with rabbit obj
        {
            rabbitIsAlive = false; // set to false when collides with player
        }
    }

    private void Update()
    {
        if(rabbitIsAlive == false)
        {
            dropMeat(); // meat drops from rabbit on frame update
        }
    }

    void dropMeat()
    {
        GameObject meatClone = (GameObject)Instantiate(Meat, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }


}
