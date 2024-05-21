using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Coded by Siena

public class IceCreamBase : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Belt")) //Destroy the game object this script is attached to if it collides with the ConveyorBelt
            Destroy(this.gameObject);
    }
}