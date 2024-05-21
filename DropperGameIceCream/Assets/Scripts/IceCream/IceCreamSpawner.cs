using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] iceScoops;

    [SerializeField]
    private GameObject[] softServe;

    [SerializeField]
    private float requiredHoldTime = 2f;


    [SerializeField]
    private float iceCreamLife = 15.0f;

    public Animator click;

    private bool isHoldingButton = false;
    

    void OnMouseDown () //This method allows the ice scoops to spawn UPON pressing the button, and not at random places
    {

        if (Input.GetMouseButtonDown(0))       
        {
            
            click.SetTrigger("Click");
            int randomScoopSpawn = UnityEngine.Random.Range(0, 3);  //random range for the balls of icream prefabs

            GameObject scoop = Instantiate(iceScoops[randomScoopSpawn], new Vector3(4.91f, -0.11f, 0f), Quaternion.identity);  //the icecream scoops will spawn at the spawner's location, which is nowhere near the button, that's why in has specific coordinates. **the vector3 numbers**
            scoop.SetActive(true);
            Destroy(scoop, iceCreamLife);
        }
        StartCoroutine(CheckMouseHold());
      
    }
    private IEnumerator CheckMouseHold()
    {
        isHoldingButton = true;
        float holdTime = 0f;
  

        while (isHoldingButton && holdTime < requiredHoldTime)
        {
            // Increment hold time while the mouse button is held
            holdTime += Time.deltaTime;

            // Check if the mouse button released
            if (Input.GetMouseButtonUp(0))
            {
                isHoldingButton = false;
                yield break; // Exit the coroutine if the mouse button  released
            }

            yield return null;
        }

        if (holdTime >= requiredHoldTime)
        {
            // Instantiate the soft serve ice cream if  mouse button held for  1sec
            click.SetTrigger("Click");
            int randomScoopSpawn = UnityEngine.Random.Range(0, softServe.Length);
            GameObject soft = Instantiate(softServe[randomScoopSpawn], new Vector3(4.91f, -0.11f, 0f), Quaternion.identity);
            soft.SetActive(true);
            Destroy(soft, iceCreamLife);
        }

        isHoldingButton = false;
    }

    void Update()
    {
        // Check if the mouse button released 
        if (Input.GetMouseButtonUp(0))
        {
            isHoldingButton = false;
        }
    }

}
