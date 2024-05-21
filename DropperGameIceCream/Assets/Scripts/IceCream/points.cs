using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public float Points;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Cones"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            Debug.Log("Collision Happen");
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore();
            }
        }
    }

}


