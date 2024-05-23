using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Coded by Siena

public class ConeSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject [] iceCreamCones;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    private float spawningCooldown = 2.0f;

    private float coneLife = 8.0f;
    private float lastSpawnTime = Mathf.NegativeInfinity;
    private int randomConeNumber; //The use of the "randomConeNumber" is to randomly choose an index from the "iceCreamCones" array

    void Update()
    {
        gameManager?.StopConeSpawning();
        gameManager?.StartCountdown();

        if(gameManager?.StopConeSpawning() == false && gameManager?.StartCountdown() == true)
        {
            if (Time.time - lastSpawnTime >= spawningCooldown)// Making a cooldown system with "spawningCooldown" for when to spawn a new ice cream cone
            {
                randomConeNumber = UnityEngine.Random.Range(0, iceCreamCones.Length);

                GameObject cone = Instantiate(iceCreamCones[randomConeNumber], transform.position, Quaternion.Euler(-180, 180, 0)); //Instantiate the cone at the spawner
                cone.SetActive(true); 
                Destroy(cone, coneLife); //Destroy the cone after coneLife seconds
                lastSpawnTime = Time.time;
            }
        }
    }
}