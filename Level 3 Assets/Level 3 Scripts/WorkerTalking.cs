using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerTalking : MonoBehaviour
{
    public GameObject FungasFlowChart;
    public AudioSource Swoosh;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject text;
    public TimerLevel3 Stopping;


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

                Stopping.countdownStop = true;
                text.SetActive(false);
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
