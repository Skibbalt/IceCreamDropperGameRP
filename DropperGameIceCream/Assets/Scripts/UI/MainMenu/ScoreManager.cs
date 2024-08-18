using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//This is Coded by Sidd

public class ScoreManager : MonoBehaviour
{
   
    public TMP_Text scoreText;

    public int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore()
    {
        score += 10 ; // This is for the Score to go straight to 10 rather than 1 points.
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString(); // This is for the Score to Show to points UI
    }

    public void DecreaseScore() 
    {
        score -= 10 ;
        UpdateScoreText();
    }
}
