using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitching : MonoBehaviour
{
    public GameObject musicoff;
    public GameObject musicofftrigger;
    public GameObject musicOn;
    public GameObject musicOntrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musicofftrigger.SetActive(false);
            musicoff.SetActive(false);
            musicOn.SetActive(true);
            musicOntrigger.SetActive(true);
        }
    }
}
