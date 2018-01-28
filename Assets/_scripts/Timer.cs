using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerLabel;
    public float CountdownFrom = 60 * 10;


    void Update()
    {
        float time = CountdownFrom - Time.timeSinceLevelLoad;

        var hours = Mathf.FloorToInt((float)(CountdownFrom - Time.timeSinceLevelLoad) / 3600);
        var minutes = Mathf.FloorToInt((float)(CountdownFrom - Time.timeSinceLevelLoad - hours * 3600) / 60);
        var seconds = Mathf.FloorToInt((CountdownFrom - Time.timeSinceLevelLoad) % 60);

        TimerLabel.text = string.Format("{0}:{1}", minutes, seconds);

        if (time <= 0f) {
            TimeUp();
        }
    }

    void TimeUp()
    {
        Debug.Log("TIMER ENDED!");
    }

}
