using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMusic : MonoBehaviour
{
    public GameObject Musicoff;
    public GameObject MusicOn;
    public GameObject TriggerOff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Musicoff.SetActive(false);
            MusicOn.SetActive(true);
            TriggerOff.SetActive(false);
        }
    }
}
