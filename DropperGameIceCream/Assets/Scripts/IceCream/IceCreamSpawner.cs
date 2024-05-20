using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] iceScoops;
    public Animator click;
    

    void OnMouseDown () //This method allows the ice scoops to spawn UPON pressing the button, and not at random places
    {

        if (Input.GetMouseButtonDown(0))       
        {
            
            click.SetTrigger("Click");
            int randomScoopSpawn = Random.Range(0, 6);  //random range for the balls of icream prefabs

            Instantiate(iceScoops[randomScoopSpawn], new Vector3(4.91f, -0.11f, 0f), Quaternion.identity);  //the icecream scoops will spawn at the spawner's location, which is nowhere near the button, that's why in has specific coordinates. **the vector3 numbers**
        }
    }
}
