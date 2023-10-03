using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerEnterFlowchart : MonoBehaviour
{
    public GameObject Flowchart;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Flowchart.SetActive(true);
        }
    }

}
