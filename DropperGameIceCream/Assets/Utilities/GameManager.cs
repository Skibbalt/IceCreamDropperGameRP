using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Coded by Siena

public class GameManager : MonoBehaviour
{
    [Header ("UI Management")]
    [SerializeField]
    GameObject mainMenuUI;
    [SerializeField]
    GameObject endGameUI;
    [SerializeField]
    GameObject startMenuUI;
    [SerializeField]
    GameObject guideMenuUI;
  
    [HideInInspector]
    public bool gameOver = false;
    private bool gameStarted = false;
    
    void Awake() //Only have the Start Menu visible
    {
        startMenuUI.SetActive(true);
        mainMenuUI.SetActive(false);
        endGameUI.SetActive(false);
        guideMenuUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void GameStarted(bool hasGameStarted) //This method is called from the "StartMenu" script
    {
        if(hasGameStarted == true)
            gameStarted = hasGameStarted;
    }

    public void GameFinished(bool isGameFinished) //Only have the End Game Menu visible. This method is called on by the "CountdownTimer" script
    {
        if(isGameFinished == true)
        {
            gameOver = true;
            mainMenuUI.SetActive(false);
            endGameUI.SetActive(true);
        }
    }

    public bool StopConeSpawning() //To stop the cones from spawning. This method will be continuously called from "ConeSpawner" script
    {
        return gameOver;
    }

    public bool StartCountdown() //This method is used to start the countdown of the timer. This method will be continuously called from "CountdownTimer" script and the "ConeSpawner" script
    {
        return gameStarted;
    }
}

//UnityEditor.EditorApplication.isPlaying = false; 
//Application.Quit();