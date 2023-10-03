using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingWait : MonoBehaviour
{
    public bool InTrigger;
    public GameObject OldmanOff;
    public GameObject OldmanOn;
    public GameObject FlowchartTrigger;

    private void OnTriggerEnter(Collider other)
    {
        InTrigger = true;
    }


    private void Update()
    {
        if(InTrigger == true)
        {
            StartCoroutine(Sequence());
            IEnumerator Sequence()
            {
                yield return new WaitForSeconds(30);
                OldmanOff.SetActive(false);
                OldmanOn.SetActive(true);
                FlowchartTrigger.SetActive(true);
            }
        }
    }
}
