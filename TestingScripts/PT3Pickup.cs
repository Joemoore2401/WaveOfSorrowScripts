using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT3Pickup : MonoBehaviour
{
    public GameObject Image3;
    public GameObject PressE;
    public GameObject PT3;
    public static bool entered2 = false;
    public PTSActive ptsActive;
    public GameObject Door6Active;
    public bool spotlight3 = false;



    void Update()
    {
        if (entered2 == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Image3.SetActive(true);
                PressE.SetActive(false);
                Door6Active.SetActive(true);
                spotlight3 = true;
                PT3.SetActive(false);
            }
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
            entered2 = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            entered2 = false;
        }
    }
}
