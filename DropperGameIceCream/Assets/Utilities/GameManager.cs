using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void GameFinished(bool isGameFinished)
    {
        if(isGameFinished == true)
            UnityEditor.EditorApplication.isPlaying = false;
    }
}

//UnityEditor.EditorApplication.isPlaying = false; 
//Application.Quit();
