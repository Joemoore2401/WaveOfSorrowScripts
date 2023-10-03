using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence3Found : MonoBehaviour
{
    public bool Inside = false;
    public AudioSource Swoosh;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject Note;
    public GameObject lightOut;
    public GameObject DocumentAdded;
    public EvidenceGathered EvidenceFound;
    public AudioSource Acquired;
    public Animator ItemUI;
    public GameObject TriggerGone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Swoosh.Play();
            Inside = true;
            FadeIn.SetTrigger("FadeIn");

        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Inside = false;
            FadeOut.SetTrigger("FadeOut");


        }
    }

    private void Update()
    {
        if (Inside == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EvidenceFound.Evidence3Collected = true;
                ItemUI.SetTrigger("ItemCollected");
                DocumentAdded.SetActive(true);
                Acquired.Play();
                Inside = false;
                FadeOut.SetTrigger("FadeOut");
                Note.SetActive(false);
                TriggerGone.SetActive(false);
                lightOut.SetActive(false);


            }

        }
    }
}
