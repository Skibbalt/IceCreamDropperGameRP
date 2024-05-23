using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

//Coded by Siddharth

public class EndGame : MonoBehaviour
{
  
    public TMP_Text scoreText;
    public ScoreManager scoreManager;

    void Start()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
