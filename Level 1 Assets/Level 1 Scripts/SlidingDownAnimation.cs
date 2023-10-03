using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SlidingDownAnimation : MonoBehaviour
{
    public GameObject AnimCamera;
    public GameObject SlidingNoise;
    public GameObject ThePlayer;
    public GameObject Ambeinceon;
    public Transform teleportTarget;
    public GameObject Blockedarea;
    public GameObject Fading;
    public GameObject triggeroff;
    public bool Entered;




    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Entered = true; 
           
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(Entered == true)
        {
            ThePlayer.SetActive(false);
            AnimCamera.SetActive(true);
            ThePlayer.GetComponent<FirstPersonController>().enabled = false;
            SlidingNoise.SetActive(true);  
            StartCoroutine(FPSSwitch());
            IEnumerator FPSSwitch()
            {
                yield return new WaitForSeconds(4);
                ThePlayer.SetActive(true);
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                ThePlayer.transform.position = teleportTarget.transform.position;
                AnimCamera.SetActive(false);
                Destroy(SlidingNoise);
                Ambeinceon.SetActive(true);               
                Blockedarea.SetActive(true);
                Fading.SetActive(true);
                triggeroff.SetActive(false);
            }
        }
      
    }
}
