using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTunnelTrigger : MonoBehaviour
{
    public Animator LeftDoor;
    public Animator RightDoor;
    public GameObject TriggerGone;
    public AudioSource SpookyNoise;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LeftDoor.SetTrigger("OfficeLeftDoor1");
            RightDoor.SetTrigger("OfficeRightDoor1");
            SpookyNoise.Play();
            TriggerGone.SetActive(false);
        }
    }
}
