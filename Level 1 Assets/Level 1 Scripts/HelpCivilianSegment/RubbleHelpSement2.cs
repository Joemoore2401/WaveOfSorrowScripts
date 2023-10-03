using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RubbleHelpSement2 : MonoBehaviour
{
    public GameObject RubblePiece;
    public GameObject RubbleDust;
    public GameObject CivDown;
    public GameObject Hammer;
    public GameObject RubbleNoise;
    public GameObject CivUp;
    public GameObject CrushedRubble;
    public bool InZone;
    public Animator FadeIn;
    public Animator FadeOut;
    public AudioSource Swoosh;
    public GameObject DisableStstem;
    public GameObject DrowningStop;
    public GameObject ThankYou;
    public GameObject SpotlightGone;
    public GameObject ThePlayer;
    public SequenceCompleted Completed;

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
                    ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                    Hammer.SetActive(true);
                    FadeOut.SetTrigger("FadeOut");
                    yield return new WaitForSeconds(1);
                    RubblePiece.SetActive(false);
                    RubbleNoise.SetActive(true);
                    RubbleDust.SetActive(true);
                    CrushedRubble.SetActive(true);
                    yield return new WaitForSeconds(2);
                    Completed.Civ3Rescued = true;
                    SpotlightGone.SetActive(false);
                    ThankYou.SetActive(true);
                    DrowningStop.SetActive(false);
                    Hammer.SetActive(false);
                    RubbleDust.SetActive(false);
                    ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                    CivDown.SetActive(false);
                    RubbleNoise.SetActive(false);
                    CivUp.SetActive(true);
                    yield return new WaitForSeconds(2);
                    DisableStstem.SetActive(false);
                }




            }
        }



    }

}
