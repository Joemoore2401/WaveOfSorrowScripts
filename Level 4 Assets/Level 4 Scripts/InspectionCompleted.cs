using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionCompleted : MonoBehaviour
{
    public bool Inspected1 = false;
    public bool Inspected2 = false;
    public bool Inspected3 = false;
    public GameObject FarmerTrigger;
    public GameObject ReturnToFarmerIndicator;



    void Update()
    {
        if(Inspected1 == true)
        {
            if (Inspected2 == true)
            {
                if (Inspected3 == true)
                {
                    FarmerTrigger.SetActive(true);
                    ReturnToFarmerIndicator.SetActive(true);
                }
            }
        }
    }
}
