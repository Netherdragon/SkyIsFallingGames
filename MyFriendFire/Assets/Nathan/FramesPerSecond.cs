using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesPerSecond : MonoBehaviour
{
    Rect fpsRect;
    
    GUIStyle style;
    private float fps;
    public float lowestFPS = 200f;

    void Start()
    {
        fpsRect = new Rect(100, 100, 400, 100);
        
        style = new GUIStyle();
        style.fontSize = 30;

        StartCoroutine(RecalculateFPS());
    }

    IEnumerator RecalculateFPS()
    {
        while (true)
        {
            fps = 1 / Time.deltaTime;
            yield return new WaitForSeconds(1);
            if (fps < lowestFPS)
            {
                lowestFPS = fps;
            }
        }
    }
    // Update is called once per frame

    void OnGUI()
    {
        GUI.Label(fpsRect, "FPS: " + fps,style);
        
    }
}
