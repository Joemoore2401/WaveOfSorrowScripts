using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic2 : MonoBehaviour
{
    public Animator Open1;
    public Animator Close1;
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
                Open1.SetTrigger("Open1");
                StartCoroutine(Closing());
                IEnumerator Closing()
                {

                    yield return new WaitForSeconds(3);
                    Close1.SetTrigger("Close1");


                }
            }
        }




    }
}
