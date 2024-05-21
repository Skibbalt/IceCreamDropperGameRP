using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Coded by Siena

public class StartMenu : MonoBehaviour
{
    [Header ("UI Management")]
    [SerializeField]
    GameObject mainMenuUI;
    [SerializeField]
    GameObject startMenuUI;
    [SerializeField]
    GameObject guideMenuUI;

    [SerializeField]
    GameManager gameManager;

    [HideInInspector]
    public bool gameStarted = true;

    public void OnStartClick() //Only having the Main Menu UI be visible
    {
        gameManager?.GameStarted(gameStarted);
        startMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }  

    public void OnGuideButtonClick() //Only have the Guide Menu UI be visible
    {
        startMenuUI.SetActive(false);
        guideMenuUI.SetActive(true); 
    }
}
