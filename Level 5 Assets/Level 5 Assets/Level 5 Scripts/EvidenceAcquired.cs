using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceAcquired : MonoBehaviour
{
    public bool Evidence01;
    public bool Evidence02;
    public bool Evidence03;
    public bool Evidence04;
    public bool Evidence05;
    public GameObject Flowchart;

    private void Update()
    {
        if(Evidence01 == true)
        {
            if (Evidence02 == true)
            {
                if (Evidence03 == true)
                {
                    if (Evidence04 == true)
                    {
                        if (Evidence05 == true)
                        {
                            Flowchart.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
