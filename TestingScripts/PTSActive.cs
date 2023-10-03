using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTSActive : MonoBehaviour
{
    public GameObject PT4;
    public bool PT1L;
    public bool PT2L;
    public bool PT3L;

    void Update()
    {
        if (PT1L == true)
        {
            if(PT2L == true)
            {
                if(PT3L == true)
                {
                    PT4.SetActive(true);
                }
            }
        }
    }
}
