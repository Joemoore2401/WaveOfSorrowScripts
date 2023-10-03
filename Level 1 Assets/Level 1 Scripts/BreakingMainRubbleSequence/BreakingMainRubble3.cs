using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BreakingMainRubble3 : MonoBehaviour
{
    public GameObject RubblePiece;
    public GameObject RubbleDust;
    public GameObject RubbleNoise;
    public GameObject CrushedRubble;
    public bool InZone;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject ThePlayer;
    public GameObject lightOff;
    public AudioSource Swoosh;
    public GameObject Hammer;
    public GameObject DisableStstem;

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
                    RubblePiece.SetActive(false);
                    RubbleDust.SetActive(true);
                    CrushedRubble.SetActive(true);
                    yield return new WaitForSeconds(2);
                    ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                    Hammer.SetActive(false);
                    RubbleNoise.SetActive(false);
                    RubbleDust.SetActive(false);
                    lightOff.SetActive(false);
                    yield return new WaitForSeconds(2);
                    DisableStstem.SetActive(false);


                }

             
            }
        }



    }
}
