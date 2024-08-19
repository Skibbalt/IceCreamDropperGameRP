using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecreaseScore : MonoBehaviour
{
    private bool coneEntered;
    private bool ScoupeEntered;
    private int WantedCone = 6;
    private int Scoupes = 7;

    private ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
        {
            coneEntered = true;
        }
        if (other.gameObject.layer == 7)
        {
            ScoupeEntered = true;
        }
        if (coneEntered == true && ScoupeEntered == false)
        {
            scoreManager.DecreaseScore();
        }
    }
}
