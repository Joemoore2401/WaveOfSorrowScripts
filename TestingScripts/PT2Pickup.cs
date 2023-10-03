using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT2Pickup : MonoBehaviour
{
    public GameObject Image2;
    public GameObject PressE;
    public GameObject PT2;
    public static bool entered1 = false;
    public PTSActive ptsActive;
    public GameObject Door2Active;
    public bool spotlight2 = false;

    void Update()
    {
        if (entered1 == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Image2.SetActive(true);
                PressE.SetActive(false);
                Door2Active.SetActive(true);
                spotlight2 = true;
                PT2.SetActive(false);
            }
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
            entered1 = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            entered1 = false;
        }
    }
}
