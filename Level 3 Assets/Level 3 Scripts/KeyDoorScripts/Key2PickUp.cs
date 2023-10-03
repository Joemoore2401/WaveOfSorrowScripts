using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2PickUp : MonoBehaviour
{
    public GameObject KeyObject;
    public AudioSource ItemCollectedNoise;
    public GameObject TriggerOff;
    public GameObject DoorTrigerActive;
    public AudioSource Swoosh;
    public Animator KeyAdded;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject PickLockTrigger;
    public GameObject ItemImage;
    public KeyDoor2 DoorLink;
    public bool Inside;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            Swoosh.Play();
            Inside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeOut.SetTrigger("FadeOut");
            Inside = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Inside == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorLink.KeyPickedUp2 = true;
                KeyObject.SetActive(false);
                FadeOut.SetTrigger("FadeOut");
                ItemImage.SetActive(true);
                ItemCollectedNoise.Play();
                PickLockTrigger.SetActive(false);
                DoorTrigerActive.SetActive(true);
                KeyAdded.SetTrigger("KeyAdded");
                TriggerOff.SetActive(false);

            }

        }



       
    }
}
