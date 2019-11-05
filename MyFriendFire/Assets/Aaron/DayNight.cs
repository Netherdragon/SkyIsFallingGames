using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public float time;
    public TimeSpan currentTime;
    public Transform SunTransform;
    public Light Sun;
    public Text timeText;
    public int Days;      

    public float intensity;
    public Color fogday = Color.grey;
    public Color fognight = Color.black;

    public int speed;


    // Update is called once per frame
    void Update()
    {
        ChangeTime();
    }

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
        timeText.text = temptime[0] + ":" + temptime[1];

        SunTransform.rotation = Quaternion.Euler(new Vector3((time - 21600) / 86400 * 360, 0, 0));
        if (time < 43200)
        {
            intensity = 1 - (43200 - time) / 43200;
        }
        else
        {
            intensity = 1 - ((43200 - time) / 43200 * -1);
        }
        RenderSettings.fogColor = Color.Lerp(fognight, fogday, intensity * intensity);

        Sun.intensity = intensity;

    }
}
