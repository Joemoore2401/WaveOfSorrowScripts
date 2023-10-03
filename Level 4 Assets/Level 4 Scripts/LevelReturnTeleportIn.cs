using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class LevelReturnTeleportIn : MonoBehaviour
{
    public bool Inside = false;
    public AudioSource Completed;
    public GameObject LevelActive;
    public GameObject ThePlayer;
    public Transform teleportTarget;
    public GameObject FadeWhite;
    public GameObject FadeIn;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            LevelActive.SetActive(true);
            ThePlayer.transform.position = teleportTarget.transform.position;
            FadeIn.SetActive(false);
            FadeWhite.SetActive(true);
            Completed.Play();

        }
    }

}
