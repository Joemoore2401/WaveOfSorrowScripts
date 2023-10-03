using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbleCollapse : MonoBehaviour
{
    public GameObject RubbleCollapsed;
    public GameObject Triggeroff;
    public GameObject rubbletriggeroff;
    public GameObject musicOff;
    public GameObject Soundeffect;
    public GameObject musicOn;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RubbleCollapsed.SetActive(true);
            Triggeroff.SetActive(false);
            rubbletriggeroff.SetActive(false);
            musicOff.SetActive(false);
            Soundeffect.SetActive(true);
            musicOn.SetActive(true);
        }
    }
}
