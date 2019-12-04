using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTrigger : MonoBehaviour
{

   public GameObject Meat;

    public virtual void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") // player tag collides with rabbit obj
        {
            Debug.Log("Drop meat");
            Destroy(this.gameObject); // rabbit is destroyed
            //GameObject meatClone = (GameObject)Instantiate(Meat, transform.position, transform.rotation);
            dropMeat();
        }
    }

    void dropMeat()
    {
        GameObject meatClone = (GameObject)Instantiate(Meat, transform.position, transform.rotation);
    }

}
