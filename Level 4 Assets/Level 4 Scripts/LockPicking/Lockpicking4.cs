using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Lockpicking4 : MonoBehaviour
{
    public GameObject Panel;
    public Animator DoorOpening;
    public AudioSource DoorSound;
    public GameObject TriggerOff;
    public GameObject TriggerOn;     
    public GameObject camActive;
    public GameObject fps;



    // Update is called once per frame
    void Update()
    {
        STPlayer();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void STPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        Panel.SetActive(true);
        camActive.SetActive(true);
        fps.SetActive(false);
    }
    public void SAPlayer()
    {
        Panel.SetActive(false);
        camActive.SetActive(false);
        fps.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        DoorOpening.SetTrigger("Door-5");
        DoorSound.Play();
        Cursor.visible = false;
        fps.GetComponent<FirstPersonController>().enabled = true;
        TriggerOn.SetActive(true);
        TriggerOff.SetActive(false);


    }
}
