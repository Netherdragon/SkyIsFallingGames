using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

// script to create a day-night cycle

public class DayNight : MonoBehaviour
{
    public float time;
    public TimeSpan currentTime;
    public Transform SunTransform;
    public Light Sun;
    //public Text timeText; // for testing
    public int Days;

    public float intensity;
    public Color fogday = Color.grey;
    public Color fognight = Color.black;

    public int speed;

    void Update()
    {
        ChangeTime();
    }

    // counts through seconds in a day
    // and rotates light accordingly

    public void ChangeTime()
    {
        time += Time.deltaTime * speed;
        if (time > 86400)
        {
            Days += 1;
            time = 0;
        }
        currentTime = TimeSpan.FromSeconds(time);
        string[] temptime = currentTime.ToString().Split(":"[0]);
        //timeText.text = temptime[0] + ":" + temptime[1];

        // light rotates to imitate the sun rising, passing overhead and then setting
        SunTransform.rotation = Quaternion.Euler(new Vector3((time - 21600) / 86400 * 360, 0, 0));
        if (time < 43200)
        {   // gets brighter
            intensity = 1 - (43200 - time) / 43200;
        }
        else
        {   // gets dimmer
            intensity = 1 - ((43200 - time) / 43200 * -1);
        }
        // not necessary but changes the look a little
        RenderSettings.fogColor = Color.Lerp(fognight, fogday, intensity * intensity);

        Sun.intensity = intensity;

    }
}
