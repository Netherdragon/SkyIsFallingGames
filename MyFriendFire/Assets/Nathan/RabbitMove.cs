using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingL = false;
    private bool isRotatingR = false;
    private bool isWalking = false;


    // Update is called once per frame
    void Update()
    {
        if(isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if (isRotatingR == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (isRotatingL == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (isWalking == true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    // Function for bunny wander AI
    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3); // time bunny is rotating
        int rotateWait = Random.Range(1, 5); // time before bunny rotates
        int rotateLorR = Random.Range(1, 3); // rotate direction
        int MoveWait = Random.Range(1, 8); // time before bunny moves forward
        int MoveTime = Random.Range(1, 5); // time bunny moves

        isWandering = true;

        yield return new WaitForSeconds(MoveWait); // bunny pauses before moving
        isWalking = true;

        yield return new WaitForSeconds(MoveTime); // bunny moves for move time
        isWalking = false;

        yield return new WaitForSeconds(rotateWait); // bunny waits for rotate wait 
        // rotate right
        if(rotateLorR == 1)
        {
            isRotatingR = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingR = false;
        }
        // rotate left
        if(rotateLorR == 2)
        {
            isRotatingL = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingL = false;
        }

        isWandering = false; // end wander
    }
}
