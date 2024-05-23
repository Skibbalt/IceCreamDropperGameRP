using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

//Coded by Siddharth

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    public ScoreManager scoreManager;

    void Awake()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
