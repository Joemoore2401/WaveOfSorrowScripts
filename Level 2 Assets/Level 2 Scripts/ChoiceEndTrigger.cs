using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceEndTrigger : MonoBehaviour
{
    public GameObject FlowchartActive;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FlowchartActive.SetActive(true);
        }
    }


}
