using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour
{
    //public GameObject tree;

    public bool triggerFall = false;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {

         if (other.gameObject.name == "ax")
         {
            transform.Rotate(90, 0, 0);  // tree.
            Debug.Log("hit by: " + gameObject.name + " position: " + transform.position);
            triggerFall = true;
            Debug.Log("triggerFall" + triggerFall);
        }
     }

    IEnumerator Disapr ()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }

    private void Update()
    {

        if (triggerFall == true)
        {
            StartCoroutine("Disapr");
        }
    }


}
