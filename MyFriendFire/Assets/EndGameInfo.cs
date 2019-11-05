using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameInfo : MonoBehaviour
{
    GUIStyle style;
    Rect fpsRect2;
    float FPS;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        FPS = GameObject.Find("GamePlayer").GetComponent<FramesPerSecond>().lowestFPS;

        health = GameObject.Find("GamePlayer").GetComponent<Wolfattack>().health;
    }

    // Update is called once per frame
    void Update()
    {
        
        fpsRect2 = new Rect(100, 200, 400, 400);
        style = new GUIStyle();
        style.fontSize = 30;

        if (health <= 0)
        {
            OnGUI();
        }
    }

    private void OnGUI()
    {
        GUI.Label(fpsRect2, " lowest FPS: " + FPS, style);
    }
}
