using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic4 : MonoBehaviour
{
    public Animator Open3;
    public Animator Close3;
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
                Open3.SetTrigger("Open3");
                StartCoroutine(Closing());
                IEnumerator Closing()
                {

                    yield return new WaitForSeconds(3);
                    Close3.SetTrigger("Close3");


                }
            }
        }




    }
}
