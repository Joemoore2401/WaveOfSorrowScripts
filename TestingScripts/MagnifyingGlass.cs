using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class MagnifyingGlass : MonoBehaviour
{
    public static bool PickedUp = false;
    public GameObject BookPanel;
    public GameObject PressE;
    public GameObject fps;
    public GameObject MagIcon;
    public GameObject Door4Active;
    public GameObject MagGone;
    public MagnifyingFeature Magged;
    public bool LogEntered = false;
    // Update is called once per frame
    void Update()
    {

        if (PickedUp == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                BookSTPlayer();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            }


        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
            PickedUp = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            PickedUp = false;
        }

    }


    public void BookSTPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        Time.timeScale = 0;
        BookPanel.SetActive(true);
        PressE.SetActive(false);
        PickedUp = false;
    }
    public void BookSAPPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = true;
        Time.timeScale = 1;
        BookPanel.SetActive(false);
        PressE.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PickedUp = false;
        Door4Active.SetActive(true);
        MagIcon.SetActive(true);
        Magged.PickedUpMag = true;
        LogEntered = true;
        MagGone.SetActive(false);

    }
}
