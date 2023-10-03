using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class DocumentInteracted : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject InteractionHighlight;
    public AudioSource Swoosh;
    public Transform teleportTarget;
    public GameObject WhitefadingOut;
    public GameObject stairs;
    public GameObject floorDeactive;
    public GameObject floorActive;
    public GameObject PlayerActive;
    public GameObject Bed;
    public AudioSource ObjectiveCompleted;
    public bool Inside = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Swoosh.Play();
            Inside = true;


        }
    }


   
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Inside = false;


        }
    }

    private void Update()
    {
        if (Inside == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(SequenceStarted());
                IEnumerator SequenceStarted()
                {
                    WhitefadingOut.SetActive(true);
                    ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                    ObjectiveCompleted.Play();
                    yield return new WaitForSeconds(5);
                    stairs.SetActive(false);
                    floorDeactive.SetActive(false);
                    floorActive.SetActive(true);
                    Bed.SetActive(true);
                    PlayerActive.SetActive(true);
                }
                
            }

        }
    }
}
