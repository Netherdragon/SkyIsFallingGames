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

    // Start is called before the first frame update
    void Start()
    {
        
    }

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

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 5);
        int rotateLorR = Random.Range(1, 2);
        int MoveWait = Random.Range(1, 8);
        int MoveTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(MoveWait);
        isWalking = true;
        yield return new WaitForSeconds(MoveTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);
        if(rotateLorR == 1)
        {
            isRotatingR = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingR = false;
        }
        if(rotateLorR == 2)
        {
            isRotatingL = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingL = false;
        }
        isWandering = false;
    }
}
