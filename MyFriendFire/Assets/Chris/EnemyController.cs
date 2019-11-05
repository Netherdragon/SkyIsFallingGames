using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other){

  //Checks if other gameobject has a Tag of Player
  if(other.gameObject.tag == "Player"){
    Time.timeScale = 0;
  }
}
}
