using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveShow : MonoBehaviour
{
    public GameObject Objective;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Objective.SetActive(true);
        }
    }
}
