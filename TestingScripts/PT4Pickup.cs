using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT4Pickup : MonoBehaviour
{


    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject PressE;
    public GameObject lockpick;
    public GameObject PT4;
    public static bool entered3 = false;
    public GameObject Door1Active;
    public bool spotlight4 = false;




    void Update()
    {
        if (entered3 == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Image1.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);
                PressE.SetActive(false);
                lockpick.SetActive(true);
                Door1Active.SetActive(true);
                spotlight4 = true;
                PT4.SetActive(false);
            }
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
            entered3 = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            entered3 = false;
        }
    }
}
