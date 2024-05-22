using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//Coded by Lui

public class IceCreamPoints : MonoBehaviour
{
    public float Points;
    private Rigidbody2D rb; 
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Cones"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

            if (scoreManager != null)
                scoreManager.IncreaseScore();
            
            this.rb.gravityScale = 0.0f; //Gravity Disabled to give the scoop enough time to settle
            StartCoroutine ("Gravity");
        }
    }
    private IEnumerator Gravity() //Returns the gravity back to normal for the scoop so it wont fall down and go along the cone.
    {
        yield return new WaitForSeconds(.02f);
        this.rb.gravityScale = 0.8f;
    }
}