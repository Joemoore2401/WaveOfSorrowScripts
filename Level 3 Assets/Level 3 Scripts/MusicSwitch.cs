using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{
    public GameObject MusicOn;
    public GameObject MusicOff;
    public GameObject TriggerGone;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            MusicOn.SetActive(true);
            MusicOff.SetActive(false);
            TriggerGone.SetActive(false);
        }
    }
}
