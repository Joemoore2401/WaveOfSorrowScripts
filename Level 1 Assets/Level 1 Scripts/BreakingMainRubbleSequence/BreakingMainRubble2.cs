using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BreakingMainRubble2 : MonoBehaviour
{

    public GameObject RubbleDust;
    public bool InZone;
    public Animator FadeIn;
    public Animator FadeOut;
    public AudioSource Swoosh;
    public GameObject ThePlayer;
    public GameObject RubbleNoise;   
    public GameObject ReEnableSystem;
    public GameObject DisableStstem;
    public GameObject Hammer;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            Swoosh.Play();
            InZone = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeOut.SetTrigger("FadeOut");
            InZone = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (InZone == true)
            {

                StartCoroutine(CivRise());

                IEnumerator CivRise()
                {
                    Hammer.SetActive(true);
                    ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                    yield return new WaitForSeconds(1);
                    FadeOut.SetTrigger("FadeOut");
                    RubbleNoise.SetActive(true);
                    RubbleDust.SetActive(true);
                    yield return new WaitForSeconds(2);
                    ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                    Hammer.SetActive(false);
                    RubbleNoise.SetActive(false);
                    RubbleDust.SetActive(false);
                    ReEnableSystem.SetActive(true);
                    Destroy(DisableStstem);

                }


            }
        }



    }
}
