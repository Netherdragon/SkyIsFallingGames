using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedDistance = 0;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot))
        {
            TargetDistance = Shot.distance;
            if(TargetDistance >= AllowedDistance)
            {
                FollowSpeed = 0.1f;
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);

            }
            else
            {
                FollowSpeed = 0;
            }
        }
    }
}
