using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingEndTrigger : MonoBehaviour
{
    public bool RockSample1 = false;
    public bool RockSample2 = false;
    public bool RockSample3 = false;
    public GameObject endtrigger;
    public GameObject normlightoff;
    public GameObject indlighton;

    void Update()
    {
        if(RockSample1 == true)
        {
            if (RockSample2 == true)
            {
                if (RockSample3 == true)
                {
                    normlightoff.SetActive(false);
                    indlighton.SetActive(true);
                    endtrigger.SetActive(true);
                }
            }
        }
    }
}
