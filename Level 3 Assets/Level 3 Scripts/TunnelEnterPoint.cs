using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class TunnelEnterPoint : MonoBehaviour
{
    public bool Inside = false;
    public AudioSource Completed;
    public GameObject ThePlayer;
    public Transform teleportTarget;
    public GameObject FadeWhite;
    public GameObject FadeIn;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            ThePlayer.transform.position = teleportTarget.transform.position;
            FadeIn.SetActive(false);
            FadeWhite.SetActive(true);
            Completed.Play();

        }
    }


  
}
