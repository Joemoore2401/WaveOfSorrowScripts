using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionDone : MonoBehaviour
{
    public bool Inspected1;
    public bool Inspected2;
    public GameObject LightOn;
    public GameObject LightOff;
    public GameObject Flowchart;



    private void Update()
    {
        if (Inspected1 == true)
        {
            if (Inspected2 == true)
            {
                Flowchart.SetActive(true);
                LightOff.SetActive(false);
                LightOn.SetActive(true);
            }
        }
    }
}
