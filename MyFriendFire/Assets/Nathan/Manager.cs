using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance = null; // game manager is empty
    public int HP = 5; // Player health
    void Awake()
    {
        if (instance == null) // game manager is empty
            instance = this; // game manager is set to the instance of the Game Manager class
        else if (instance != this) // Determine is instance is already assigned to something else
            Destroy(gameObject); // destroys extra game manager
    }

   public void AddHealth()
    {
        HP++; // game manager increases player health when player touches meat.
    }
    
}
