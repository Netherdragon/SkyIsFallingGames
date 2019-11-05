using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour
{
    private int treeHealth = 2;
    public GameObject wood;
    public GameObject player;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {


        if (other.gameObject.name == "player")
        {
            treeHealth -= 1;
            Debug.Log("health: " + treeHealth);
        }
    }

    IEnumerator Disapr()
    {
        Instantiate(wood, new Vector3(player.transform.position.x - 1f, 0, player.transform.position.z - 1f), Quaternion.identity);
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if (treeHealth <= 0)
        {
            transform.Rotate(90, 0, 0);  // tree.
            Debug.Log("hit by: " + gameObject.name + " position: " + transform.position);
            StartCoroutine("Disapr");
        }
            

    }
}
