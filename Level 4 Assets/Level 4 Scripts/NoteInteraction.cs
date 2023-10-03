using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class NoteInteraction : MonoBehaviour
{
    public Animator FadeIn;
    public Animator FadeOut;
    public AudioSource Swoosh;
    public GameObject Camactive;
    public GameObject Note;
    public GameObject buttonUI;
    public GameObject fps;
    public GameObject Blockingarea;
    public GameObject displayRubble;
    public GameObject musicOff;
    public GameObject musicOn;
    public GameObject triggeroff;
    public GameObject FadeInUi;
    public GameObject RubbleTrigger;
    public bool Interacted;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Swoosh.Play();
            FadeIn.SetTrigger("FadeIn");
            Interacted = true;
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            FadeOut.SetTrigger("FadeOut");
            Interacted = false;
        }
    }

    void Update()
    {
        if (Interacted == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(CamSequence());
                IEnumerator CamSequence()
                {
                    FadeOut.SetTrigger("FadeOut");
                    buttonUI.SetActive(true);
                    Blockingarea.SetActive(false);
                    Note.SetActive(false);
                    fps.SetActive(false);
                    musicOff.SetActive(false);
                    musicOn.SetActive(true);
                    displayRubble.SetActive(true);
                    Camactive.SetActive(true);
                    yield return new WaitForSeconds(5);
                    FadeInUi.SetActive(true);
                    fps.SetActive(true);
                    fps.SetActive(true);
                    RubbleTrigger.SetActive(true);
                    triggeroff.SetActive(false);

                }

            }
        }
    }


}
