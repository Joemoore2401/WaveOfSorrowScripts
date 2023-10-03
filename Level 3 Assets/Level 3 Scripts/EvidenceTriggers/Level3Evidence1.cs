using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Evidence1 : MonoBehaviour
{
    public TunnelTriggerActivation Evidence;
    public GameObject Paper;
    public AudioSource EvidenceNoise;
    public GameObject triggeroff;
    public AudioSource Swoosh;
    public GameObject ItemInv;
    public GameObject IndLightoff;
    public GameObject normLighton;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject ItemAcquired;
    public bool InArea;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InArea = true;
            Swoosh.Play();
            FadeIn.SetTrigger("FadeIn");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        InArea = false;
        FadeOut.SetTrigger("FadeOut");
    }


    private void Update()
    {
        if(InArea == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Evidence.ExtraEvidence1 = true;
                FadeOut.SetTrigger("FadeOut");
                Paper.SetActive(false);
                ItemAcquired.SetActive(true);
                normLighton.SetActive(true);
                IndLightoff.SetActive(false);
                ItemInv.SetActive(true);
                EvidenceNoise.Play();
                triggeroff.SetActive(false);
            }



          
        }
    }
}
