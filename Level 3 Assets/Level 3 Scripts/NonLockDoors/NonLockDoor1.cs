using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonLockDoor1 : MonoBehaviour
{
    public bool InsideTrigger;
    public Animator NonLockOpen;
    public GameObject Triggeroff;
    public GameObject IndicatorLight;
    public GameObject NormLight;
    public AudioSource Swoosh;
    public GameObject DoorOpen;
    public Animator FadeIn;
    public Animator Fadeout;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            Swoosh.Play();
            InsideTrigger = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Fadeout.SetTrigger("FadeOut");
        InsideTrigger = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(InsideTrigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Fadeout.SetTrigger("FadeOut");
                NonLockOpen.SetTrigger("PicklockMetalDoor3");
                IndicatorLight.SetActive(false);
                NormLight.SetActive(true);
                DoorOpen.SetActive(true);
                Triggeroff.SetActive(false);
            }
        }
    }
}
