using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelTriggerActivation : MonoBehaviour
{
    public bool ExtraEvidence1;
    public bool ExtraEvidence2;
    public bool ExtraEvidence3;
    public bool ExtraEvidence4;
    public GameObject IndicatorLight1;
    public GameObject normLightoff1;
    public GameObject normLightoff2;
    public GameObject IndicatorLight2;
    public GameObject TunnelTrigger;
    public GameObject FlowchartActive;
    public GameObject Character;

    void Update()
    {
        if (ExtraEvidence1 == true)
        {
            if (ExtraEvidence2 == true)
            {
                if (ExtraEvidence3 == true)
                {
                    if (ExtraEvidence4 == true)
                    {
                        normLightoff1.SetActive(false);
                        normLightoff2.SetActive(false);
                        IndicatorLight1.SetActive(true);
                        Character.SetActive(true);
                        IndicatorLight2.SetActive(true);
                        TunnelTrigger.SetActive(true);
                        FlowchartActive.SetActive(true);
                    }
                }
            }
        }
    }
}
