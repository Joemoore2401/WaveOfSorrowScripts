using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightOn : MonoBehaviour
{

    public GameObject Lighton;
    public GameObject Lightofftrigger;
    public GameObject Lightontrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Lighton.SetActive(true);
            Lightofftrigger.SetActive(true);
            Lightontrigger.SetActive(false);
        }

    }
}
