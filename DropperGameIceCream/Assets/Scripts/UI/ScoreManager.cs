using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int pointsGathered = 0;
    public TMP_Text scoreText; // Change from Text to TMP_Text
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore()
    {
        score += 10 ;
        pointsGathered ++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    
}
