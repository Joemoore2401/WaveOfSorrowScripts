using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormDoor2 : MonoBehaviour
{
    public Animator FadeIn;
    public Animator FadeOut;
    public Animator Normdoor;
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

            FadeIn.SetTrigger("FadeOut");
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
                FadeIn.SetTrigger("FadeOut");
                Normdoor.SetTrigger("Door-12");
                TriggerOff.SetActive(false);
            }
        }
    }
}
