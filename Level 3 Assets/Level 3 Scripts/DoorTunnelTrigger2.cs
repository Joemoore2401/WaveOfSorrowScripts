using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTunnelTrigger2 : MonoBehaviour
{
    public Animator LeftDoor;
    public Animator RightDoor;
    public GameObject TriggerGone;
    public AudioSource SpookyNoise;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LeftDoor.SetTrigger("OfficeLeftDoor2");
            RightDoor.SetTrigger("OfficeRightDoor2");
            SpookyNoise.Play();
            TriggerGone.SetActive(false);
        }
    }
}
