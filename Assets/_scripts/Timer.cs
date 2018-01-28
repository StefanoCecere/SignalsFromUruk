using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerLabel;
    private float CountdownFrom = 60 * 10;

    void Update()
    {
        float timeRemaining = CountdownFrom - Time.timeSinceLevelLoad;

        var hours = Mathf.FloorToInt((float)(timeRemaining) / 3600);
        var minutes = Mathf.FloorToInt((float)(timeRemaining - hours * 3600) / 60);
        var seconds = Mathf.FloorToInt((timeRemaining) % 60);

        TimerLabel.text = string.Format("{0}:{1}", minutes, seconds);

        if (timeRemaining <= 0f) {
            TimeUp();
        }
    }

    void TimeUp()
    {
        Debug.Log("TIMER ENDED!");
    }

}
