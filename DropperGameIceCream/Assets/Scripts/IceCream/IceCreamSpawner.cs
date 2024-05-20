using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IceCreamSpawner : MonoBehaviour
{
    public GameObject ScoopIceCreamPrefab;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ScoopIceCreamPrefab,transform.position,Quaternion.identity);
        }
           
    }
}
