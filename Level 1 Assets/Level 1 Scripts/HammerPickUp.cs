using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerPickUp : MonoBehaviour
{
    public GameObject Hammer;
    public GameObject Civ1;
    public GameObject Civ2;
    public GameObject Civ3;
    public GameObject NonCiv1;
    public GameObject NonCiv2;
    public GameObject NonCiv3;
    public GameObject pickedup;
    public static bool InZone;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject Contactoff;
    public AudioSource Swoosh;
    public GameObject LightOff;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            Swoosh.Play();
            InZone = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeOut.SetTrigger("FadeOut");
            InZone = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (InZone == true)
            {
                FadeOut.SetTrigger("FadeOut");
                pickedup.SetActive(true);
                Civ1.SetActive(true);
                Civ2.SetActive(true);
                Civ3.SetActive(true);
                NonCiv1.SetActive(false);
                NonCiv2.SetActive(false);
                NonCiv3.SetActive(false);
                Hammer.SetActive(false);
                LightOff.SetActive(false);
                Contactoff.SetActive(false);
                
               




            }
        }
    }
}