using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class LockPickDoor5 : MonoBehaviour
{
    public GameObject Panel;
    public Animator ChestOpening;
    public Animator FadingIn;
    public Animator FadingOut;
    public AudioSource Swoosh;
    public GameObject DoorSound;
    public GameObject IndicatorLight;
    public GameObject NormLight;
    public GameObject TriggerOff;
    public GameObject Key2Off;
    public GameObject KeyTrigger2Off;
    public GameObject EvidenceTrigger;
    public GameObject camActive;
    public GameObject fps;
    public static bool cold = false;


    // Update is called once per frame
    void Update()
    {


        if (cold == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                STPlayer();

            }


        }




    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadingIn.SetTrigger("FadeIn");
            cold = true;
            Swoosh.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadingOut.SetTrigger("FadeOut");
            cold = false;
        }

    }
    public void STPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        Panel.SetActive(true);
        FadingOut.SetTrigger("FadeOut");
        camActive.SetActive(true);
        fps.SetActive(false);
    }
    public void SAPlayer()
    {
        
        
        Panel.SetActive(false);
        camActive.SetActive(false);
        fps.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        ChestOpening.SetTrigger("Chest2");
        DoorSound.SetActive(true);
        Cursor.visible = false;
        fps.GetComponent<FirstPersonController>().enabled = true;
        Key2Off.SetActive(false);
        KeyTrigger2Off.SetActive(false);
        IndicatorLight.SetActive(false);
        NormLight.SetActive(true);
        EvidenceTrigger.SetActive(true);
        TriggerOff.SetActive(false);


    }
}
