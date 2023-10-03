using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownActivation : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject Text;
    public GameObject Triggeroff;
    public GameObject ObjectiveFade;
    public GameObject HintFade;
    public GameObject PauseActive;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           CountDown.SetActive(true);
            ObjectiveFade.SetActive(true);
            HintFade.SetActive(true);
           Text.SetActive(true);    
           Triggeroff.SetActive(false);
            PauseActive.SetActive(true);

        }
    }
}
