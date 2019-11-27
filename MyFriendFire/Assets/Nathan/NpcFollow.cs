using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFollow : MonoBehaviour
{
    GameObject ThePlayer;
    private float FarthestPoint = 50; // distance if farther than, wolf will ignore player
    private float FollowSpeed; // wolf chase speed
    private float distance; // distance between player and wolf


    // Update is called once per frame

    private void Start()
    {
        ThePlayer = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        transform.LookAt(ThePlayer.transform); // wolf faces the player object

        distance = Vector3.Distance(transform.position, ThePlayer.transform.position); // distance between wolf and player

        if(distance < FarthestPoint)
        {
            FollowSpeed = 0.2f; // follow speed
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed); 
        }
        else
        {
             FollowSpeed = 0;
        }
    }
}
