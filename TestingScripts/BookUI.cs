using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class BookUI : MonoBehaviour
{
    public static bool PickedUp = false;
    public GameObject BookPanel;
    public GameObject PressE;
    public GameObject fps;
    public GameObject book;
    public bool Acquired = false;
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
        Acquired = true;
        book.SetActive(false);
        PickedUp = false;
    }
}
