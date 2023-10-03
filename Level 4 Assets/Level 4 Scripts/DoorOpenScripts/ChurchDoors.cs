using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchDoors : MonoBehaviour
{
    public Animator FadeIn;
    public Animator FadeOut;
    public Animator ChurchDoor1;
    public Animator ChurchDoor2;
    public AudioSource Ghost;
    public AudioSource Swoosh;
    public AudioSource DoorOpen;
    public GameObject TriggerOff;
    public bool Interacted;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Swoosh.Play();
            FadeIn.SetTrigger("FadeIn");
            Interacted = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            FadeOut.SetTrigger("FadeOut");
            Interacted = false;
        }
    }


    void Update()
    {
        if (Interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorOpen.Play();
                Ghost.Play();
                FadeOut.SetTrigger("FadeOut");
                ChurchDoor1.SetTrigger("Door-15");
                ChurchDoor2.SetTrigger("Door-16");
                TriggerOff.SetActive(false);
            }
        }
    }
}
