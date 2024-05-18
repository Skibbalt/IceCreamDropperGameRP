using System.Collections;
using System.Collections.Generic;
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

    [HideInInspector]
    public bool gameOver = false;

    void Awake() //Only have the Main Menu visible
    {
        mainMenuUI.SetActive(true);
        endGameUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            UnityEditor.EditorApplication.isPlaying = false; 
    }

    public void GameFinished(bool isGameFinished) //Only have the End Game Menu visible
    {
        if(isGameFinished == true)
        {
            gameOver = true;
            mainMenuUI.SetActive(false);
            endGameUI.SetActive(true);
        }
    }

    public bool StopConeSpawning() //To stop the cones from spawning. This method will be continuously called from "ConeSpawner"
    {
        return gameOver;
    }
}

//UnityEditor.EditorApplication.isPlaying = false; 
//Application.Quit();
