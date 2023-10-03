using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DialougeInteraction : MonoBehaviour
{
    public GameObject FungasFlowChart;
    public AudioSource Swoosh;
    public Animator FadeIn;
    public Animator FadeOut;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Swoosh.Play();
            FadeIn.SetTrigger("FadeIn");

        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               

                FungasFlowChart.SetActive(true);               
                FadeOut.SetTrigger("FadeOut");
            }


        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            FadeOut.SetTrigger("FadeOut");


        }
    }
}
