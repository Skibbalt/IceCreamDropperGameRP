using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Coded by Siena

public class GuideMenu : MonoBehaviour
{
    [Header ("UI Management")]
    [SerializeField]
    GameObject guideMenuUI;
    [SerializeField]
    GameObject startMenuUI;

    public void OnExitClick()
    {
        startMenuUI.SetActive(true);
        guideMenuUI.SetActive(false);
    }
}
