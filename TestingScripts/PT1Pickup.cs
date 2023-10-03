using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT1Pickup : MonoBehaviour
{
    public GameObject Image1;
    public GameObject PressE;
    public GameObject PT1;
    public static bool entered = false;
    public PTSActive ptsActive;
    public GameObject Door5Active;
    public bool Spotlight = false;
   



    void Update()
    {
        if(entered == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Image1.SetActive(true);
                PressE.SetActive(false);
                Door5Active.SetActive(true);
                Spotlight = true;
                PT1.SetActive(false);
            }
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
            entered = true;
        }
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            entered = false;
        }
    }

    internal static PT1Pickup FindObjectOfType(bool toObjective2)
    {
        throw new NotImplementedException();
    }
}
