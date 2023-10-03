using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspection3 : MonoBehaviour
{
    public AudioSource EvidenceNoise;
    public AudioSource Swoosh;
    public GameObject ItemInv;
    public GameObject FlowchartActive;
    public Animator FadeIn;
    public Animator FadeOut;
    public bool InArea;
    public InspectionCompleted Inspected;





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
        if (InArea == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FadeOut.SetTrigger("FadeOut");
                Inspected.Inspected3 = true;
                FlowchartActive.SetActive(true);
                ItemInv.SetActive(true);
                EvidenceNoise.Play();
            }



        }
    }
}
