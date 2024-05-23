using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gravity funciontality with the rigidbody coded by Luis
//The rest is coded by Sidd

public class IceCreamBase : MonoBehaviour
{
    [SerializeField]
    private float Points;

    [SerializeField]
    private int tagNumber;

    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Belt")) //Destroy the game object this script is attached to if it collides with the ConveyorBelt
            Destroy(this.gameObject);

        if (other.gameObject.GetComponent<Cone>()) //This "if" statement is to add points depending on the ice cream
        {
            if (other.gameObject.GetComponent<Cone>().tagNumber == tagNumber)
            {
                ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

                if (scoreManager != null)
                    scoreManager.IncreaseScore();

                this.rb.gravityScale = 0.0f; //Gravity Disabled to give the scoop enough time to settle
                StartCoroutine("Gravity");
            }
        }
    }

    private IEnumerator Gravity() //Returns the gravity back to normal for the scoop so it wont fall down and go along the cone.
    {
        yield return new WaitForSeconds(.02f);
        this.rb.gravityScale = 0.8f;
    }
}