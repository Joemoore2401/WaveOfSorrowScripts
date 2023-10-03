using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightOff : MonoBehaviour
{
    public GameObject Lighton;
    public GameObject Lightofftrigger;
    public GameObject Lightontrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Lighton.SetActive(false);
            Lightofftrigger.SetActive(false);
            Lightontrigger.SetActive(true);
        }

    }
}
