using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic3 : MonoBehaviour
{
    public Animator Open2;
    public Animator Close2;
    public GameObject PressF;
    public static bool DoorVintage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressF.SetActive(true);
            DoorVintage = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressF.SetActive(false);
            DoorVintage = false;
        }
    }

    void Update()
    {
        if (DoorVintage == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Open2.SetTrigger("Open2");
                StartCoroutine(Closing());
                IEnumerator Closing()
                {

                    yield return new WaitForSeconds(3);
                    Close2.SetTrigger("Close2");


                }
            }
        }




    }
}
