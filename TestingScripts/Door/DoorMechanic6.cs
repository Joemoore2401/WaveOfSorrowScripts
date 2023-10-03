using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic6 : MonoBehaviour
{
    public Animator Open5;
    public Animator Close5;
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
                Open5.SetTrigger("Open5");
                StartCoroutine(Closing());
                IEnumerator Closing()
                {

                    yield return new WaitForSeconds(3);
                    Close5.SetTrigger("Close5");


                }
            }
        }




    }
}
