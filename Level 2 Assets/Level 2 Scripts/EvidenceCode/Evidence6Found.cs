using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Evidence6Found : MonoBehaviour
{
    public bool Inside = false;
    public AudioSource Swoosh;
    public Animator FadeIn;
    public GameObject ThePlayer;
    public Animator FadeOut;
    public Transform teleportTargetfps;
    public GameObject Note;
    public GameObject WhitefadingOut;
    public GameObject stairs;
    public GameObject Bed;
    public GameObject floorDeactive;
    public GameObject floorActive;
    public GameObject lightOut;
    public GameObject DocumentAdded;
    public EvidenceGathered EvidenceFound;
    public Animator ItemUI;
    public AudioSource Acquired;
    public GameObject TriggerGone;
    public GameObject CivTrigger;

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



                ThePlayer.transform.position = teleportTargetfps.transform.position;
                EvidenceFound.Evidence6Collected = true;
                    ItemUI.SetTrigger("ItemCollected");
                    DocumentAdded.SetActive(true);
                    Acquired.Play();
                    FadeOut.SetTrigger("FadeOut");
                    Note.SetActive(false);
                    TriggerGone.SetActive(false);
                    WhitefadingOut.SetActive(true);
                    stairs.SetActive(false);
                    floorDeactive.SetActive(false);
                    floorActive.SetActive(true);                   
                    Bed.SetActive(true);
                    lightOut.SetActive(false);
                CivTrigger.SetActive(true);
                





               



            }

        }
    }
}
