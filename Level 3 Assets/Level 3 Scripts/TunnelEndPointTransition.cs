using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TunnelEndPointTransition : MonoBehaviour
{
    public bool Inside = false;
    public AudioSource Completed;
    public GameObject ThePlayer;
    public Transform teleportTarget;
    public GameObject FadeWhite;
    public GameObject FadeIn;
    public GameObject MusicOn;
    public GameObject MusicOff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Inside = true;


        }
    }


    private void Update()
    {
        if (Inside == true)
        {
            StartCoroutine(SequenceStarted());
            IEnumerator SequenceStarted()
            {
                FadeIn.SetActive(false);
                FadeWhite.SetActive(true);
                Completed.Play();
                MusicOff.SetActive(false);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                yield return new WaitForSeconds(5);
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                ThePlayer.transform.position = teleportTarget.transform.position;
                FadeWhite.SetActive(false);
                MusicOn.SetActive(true);
                FadeIn.SetActive(true);
             
            }
        }
    }
}
