using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic5 : MonoBehaviour
{
    public Animator Open4;
    public Animator Close4;
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
                Open4.SetTrigger("Open4");
                StartCoroutine(Closing());
                IEnumerator Closing()
                {

                    yield return new WaitForSeconds(3);
                    Close4.SetTrigger("Close4");


                }
            }
        }




    }
}
