using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSegment : MonoBehaviour
{
    public GameObject FPSOff;
    public GameObject sliding;
    public Transform teleportTarget;
    public GameObject FPSOn;
    public GameObject SlidingNoise;
    public GameObject Ambeinceon;
    public GameObject Blockedarea;
    public GameObject ThePlayer;
    public GameObject Fading;
    public GameObject Triggeroff;
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
        if (Entered == true)
        {
            FPSOff.SetActive(false);
            SlidingNoise.SetActive(true);
            Ambeinceon.SetActive(false);
            sliding.SetActive(true);
            StartCoroutine(FPSSwitch());
            IEnumerator FPSSwitch()
            {
                yield return new WaitForSeconds(8);
                Entered = false;
                SlidingNoise.SetActive(false);
                Ambeinceon.SetActive(true);
                sliding.SetActive(false);
                FPSOn.SetActive(true);
                Blockedarea.SetActive(true);
                ThePlayer.transform.position = teleportTarget.transform.position;
                Fading.SetActive(true);
                Triggeroff.SetActive(false);

            }
        }

    }
}
