using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceGathered : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject TriggerActivated;
    public bool Evidence1Collected;
    public bool Evidence2Collected;
    public bool Evidence3Collected;
    public bool Evidence4Collected;
    public bool Evidence5Collected;
    public bool Evidence6Collected;
    public bool Evidence7Collected;
    public bool Evidence8Collected;
    public bool Evidence9Collected;
    public bool Evidence10Collected;

    // Update is called once per frame
    void Update()
    {
        if (Evidence1Collected == true)
        {
            if (Evidence2Collected == true)
            {
                if (Evidence3Collected == true)
                {
                    if (Evidence4Collected == true)
                    {
                        if (Evidence5Collected == true)
                        {
                            if (Evidence6Collected == true)
                            {
                                if (Evidence7Collected == true)
                                {
                                    if (Evidence8Collected == true)
                                    {
                                        if (Evidence9Collected == true)
                                        {
                                            if (Evidence10Collected == true)
                                            {
                                                TriggerActivated.SetActive(true);
                                                light1.SetActive(true);
                                                light2.SetActive(true);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
