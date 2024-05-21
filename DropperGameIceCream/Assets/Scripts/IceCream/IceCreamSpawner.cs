using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Coded by Lui

public class IcecreamSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] iceScoops; //This is an array of random iceCream scoops that will be chosen

    [SerializeField]
    private GameObject[] softServe; //This is an array of random softServe scoops that will be chosen

    [SerializeField]
    private float requiredHoldTime = 0.5f; //This is for holding the button to spawn "softServe"

    private float iceCreamLife = 8.0f;
    public Animator click;
    private bool isHoldingButton = false;

    void Update()
    {
        // Check if the mouse button released 
        if (Input.GetMouseButtonUp(0))
            isHoldingButton = false;
    }
    
    void OnMouseDown() //This method allows the ice scoops to spawn UPON pressing the button, and not at random places
    {

        if (Input.GetMouseButtonDown(0))       
        {
            click.SetTrigger("Click");
            int randomScoopSpawn = UnityEngine.Random.Range(0, 3);  //Random range for the balls of icream prefabs
            GameObject scoop = Instantiate(iceScoops[randomScoopSpawn], new Vector3(4.91f, -0.11f, 0f), Quaternion.identity);  
            //The icecream scoops will spawn at the spawner's location, which is nowhere near the button, that's why in has specific coordinates. **the vector3 numbers**
            scoop.SetActive(true);
            Destroy(scoop, iceCreamLife); //Destroy the "scoop" after iceCreamLife seconds
        }

        StartCoroutine(CheckMouseHold());
    }

    private IEnumerator CheckMouseHold() //This method allows the soft serve scoops to spawn UPON pressing the button, and not at random places
    {
        isHoldingButton = true;
        float holdTime = 0f;

        while (isHoldingButton && holdTime < requiredHoldTime)
        {
            // Increment hold time while the mouse button is held
            holdTime += Time.deltaTime;

            //Check if the mouse button released
            if (Input.GetMouseButtonUp(0))
            {
                isHoldingButton = false;
                yield break; // Exit the coroutine if the mouse button  released
            }
            yield return null;
        }

        if (holdTime >= requiredHoldTime) //Instantiate the soft serve ice cream if  mouse button held for the "requiredHoldTime"
        {
            click.SetTrigger("Click");
            int randomScoopSpawn = UnityEngine.Random.Range(0, softServe.Length);
            GameObject soft = Instantiate(softServe[randomScoopSpawn], new Vector3(4.91f, -0.11f, 0f), Quaternion.identity);
            soft.SetActive(true);
            Destroy(soft, iceCreamLife); //Destroy the "soft" after iceCreamLife seconds
        }

        isHoldingButton = false;
    }
}
