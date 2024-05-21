using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

//Coded by Siena

//I ran into an issue. If you run the game and look in the scene, it spawns the cones just fine and they're visible. However, in the game view, you don't see the cones.
//I don't know why this happens. I tried setting the game objects in the array to be true, but they still don't appear
//I also tried making the cones be on a different layer that's named CONES, but it also hasn't worked

public class ConeSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject [] iceCreamCones;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    private float spawningCooldown = 2.0f;

    [SerializeField]
    private float coneLife = 15.0f;

    private float lastSpawnTime = Mathf.NegativeInfinity;
    private int randomConeNumber; //The use of the "randomConeNumber" is to randomly choose an index from the "iceCreamCones" array

    void Update()
    {
        gameManager?.StopConeSpawning();
        gameManager?.StartCountdown();

        if(gameManager?.StopConeSpawning() == false && gameManager?.StartCountdown() == true)
        {
            if (Time.time - lastSpawnTime >= spawningCooldown)// Making a cooldown system with "spawningCooldown"
            {
                randomConeNumber = UnityEngine.Random.Range(0, iceCreamCones.Length);

                GameObject cone = Instantiate(iceCreamCones[randomConeNumber], transform.position, Quaternion.Euler(-180, 180, 0)); // instantiate the cone at the spawner
                cone.SetActive(true); //instantiated cone is active
                Destroy(cone, coneLife); // Destroy the cone after coneLife seconds
                lastSpawnTime = Time.time;

              
            }
        }
        
    }
}

//float randomFloat = Random.value; //This value will be between 0 and 1

/*if(Random.value < 0.3f)
    //Success!!*/