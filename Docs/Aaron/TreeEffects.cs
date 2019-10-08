using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeEffects : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        Quaternion target = Quaternion.Euler(0f, 0f, 180f);
        float smooth = 5.0f;
        if (collision.gameObject.name == "Cube") {
            Debug.Log("collision");
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
    }





}
