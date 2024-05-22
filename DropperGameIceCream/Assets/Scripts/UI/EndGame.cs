using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
    public TMP_Text scoreText;


    void Start()
    {
        scoreText.text = "Points Text: " + scoreText;
    }
}
