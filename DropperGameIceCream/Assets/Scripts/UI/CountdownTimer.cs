using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField]
    TMP_Text timerText;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    private float timeBeforeGameEnds = 10.0f; //No matter what value, the timer goes below 0. It goes to -1 seconds then -2 seconds before it actually quits the game. Idk why

    [HideInInspector]
    public bool finishedGameCountdown = false;

    void Awake()
    {
       
    }

    void Update()
    {
        if(timeBeforeGameEnds >= 0)
            timeBeforeGameEnds -= Time.deltaTime; //Counting down "timeBeforeGameEnds" 
        DisplayTime(timeBeforeGameEnds);

        if (timeBeforeGameEnds < 0)
        {
            finishedGameCountdown = true;
            gameManager?.GameFinished(finishedGameCountdown);
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; //Need to add one to "timeBeforeGameEnds" to avoid the seconds going to -1 seconds when being displayed in the game
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //Formatting "timeBeforeGameEnds" into seconds 
        timerText.text = string.Format(" Timer : {0:00}", seconds); //Text display for UI
    }
}