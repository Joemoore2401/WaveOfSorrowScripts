using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DoorChoice : MonoBehaviour
{
    public GameObject panelActive;
    public GameObject LockpickPanel;    
    public GameObject flowchart;
    public GameObject fps;
    public GameObject CamActive;
    public Animator FadeIn;
    public Animator FadeOut;
    public AudioSource Swoosh;
    public GameObject Trigger;
    public bool InTrigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            Swoosh.Play();
            InTrigger = true;
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

    // Update is called once per frame
    void Update()
    {
        if(InTrigger == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                fps.GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                FadeOut.SetTrigger("FadeOut");
                Cursor.visible = true;
                fps.SetActive(false);
                CamActive.SetActive(true);
                panelActive.SetActive(true);
                
            }
        }
    }



    public void Lockpick()
    {
        panelActive.SetActive(false);
        CamActive.SetActive(false);
        LockpickPanel.SetActive(true);
        Trigger.SetActive(false);
    }

    public void DoorDown()
    {
        fps.GetComponent<FirstPersonController>().enabled = true;
        fps.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        flowchart.SetActive(true);
        panelActive.SetActive(false);
        Trigger.SetActive(false);
    }
}
