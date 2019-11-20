using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFollow : MonoBehaviour
{
    GameObject ThePlayer;
    public float TargetDistance; // var to ignore distances greater than targetDistance
    public float AllowedDistance = 5;
    public float FollowSpeed;
    public RaycastHit Shot;


    // Update is called once per frame
    private void Start()
    {
        ThePlayer = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot)) // wolf tracks the player
        {
            TargetDistance = Shot.distance; // if target distance is greater than shot distance, wolf should ignore the player
     //       Debug.Log("wolf distance: " + TargetDistance);

            if(TargetDistance <= AllowedDistance)
            {
                FollowSpeed = 0.1f;
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed); // wolf moves towards the player
            }
            else
            {
                FollowSpeed = 0; // wolf is too far away from player to chase so followspeed is 0.
            }
        }
    }
}
