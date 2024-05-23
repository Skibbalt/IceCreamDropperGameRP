using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

//This is Done By Siddharth
public class EndGame : MonoBehaviour
{
    public TMP_Text scoreText;
    public ScoreManager scoreManager;

    void Start()
    {
        //scoreManager = GetComponent<ScoreManager>();
        scoreText.text = scoreManager.score.ToString();
    }
}
