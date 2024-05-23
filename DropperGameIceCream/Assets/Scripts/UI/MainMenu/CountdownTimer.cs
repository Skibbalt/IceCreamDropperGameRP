using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Coded by Siena

public class CountDownTimer : MonoBehaviour
{
    [SerializeField]
    TMP_Text timerText;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    private float timeBeforeGameEnds = 30.0f;

    [HideInInspector]
    public bool finishedGameCountdown = false;

    void Update()
    {
        gameManager?.StartCountdown();

        if(gameManager?.StartCountdown() == true)
        {
            DisplayTime(timeBeforeGameEnds);

            if(timeBeforeGameEnds >= 0)
                timeBeforeGameEnds -= Time.deltaTime; //Counting down "timeBeforeGameEnds" 
        
            if (timeBeforeGameEnds < 0) //When "timeBeforeGameEnds" reaches zero
            {
                finishedGameCountdown = true;
                gameManager?.GameFinished(finishedGameCountdown);
            }
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; //Need to add one to "timeBeforeGameEnds" to avoid the seconds going to -1 seconds when being displayed in the game
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //Formatting "timeBeforeGameEnds" into seconds 
        timerText.text = string.Format(" Timer : {0:00}", seconds); //Text display for UI
    }
}