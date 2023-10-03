using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickedUp : MonoBehaviour
{
    public GameObject note;
    public GameObject Invimage;
    public AudioSource ItemGathered;
    public AudioSource Swoosh;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject Trigger;
    public GameObject ItemTextUI;
    public GameObject TriggerActive;
    public bool InTrigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            InTrigger = true;
            Swoosh.Play();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeOut.SetTrigger("FadeOut");
            InTrigger = false;
           
        }
    }


    void Update()
    {
        if(InTrigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                FadeOut.SetTrigger("FadeOut");
                note.SetActive(false);
                ItemTextUI.SetActive(true);
                ItemGathered.Play();
                Invimage.SetActive(true);
                TriggerActive.SetActive(true);
                Trigger.SetActive(false);
            }
        }
    }
}
