using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody playerBody;
	private Vector3 inputVector;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal") * 10f, 0, Input.GetAxis("Vertical") * 10f);
		transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
		playerBody.velocity = inputVector;


        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
