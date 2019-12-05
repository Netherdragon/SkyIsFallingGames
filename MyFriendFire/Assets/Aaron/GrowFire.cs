using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowFire : MonoBehaviour
{
    GameObject wood;
    public GameObject firewood;
    public GameObject fire;
    private void Start()
    {
        wood = GameObject.FindGameObjectWithTag("Player");  
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            
            if (wood.GetComponent<GatherWood>().numberOfFirewood > 0)
            {
                wood.GetComponent<GatherWood>().numberOfFirewood--;
                Debug.Log("number of firewood: " + wood.GetComponent<GatherWood>().numberOfFirewood);
                Instantiate(firewood, new Vector3(fire.transform.position.x, 6.0f, fire.transform.position.z), transform.rotation);
            }
            else
            {
                Debug.Log("no firewood");
            }
        }
    }

}
