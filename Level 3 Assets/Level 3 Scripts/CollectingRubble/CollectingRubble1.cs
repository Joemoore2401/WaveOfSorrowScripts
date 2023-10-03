using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CollectingRubble1 : MonoBehaviour
{
    public GameObject Triggeroff;
    public GameObject rubbleSmoke;
    public AudioSource Swoosh;
    public AudioSource Evidence;
    public GameObject ItemInventory1;
    public GameObject RockSmashNoise;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject thePlayer;
    public GameObject ItemAqcuired;
    public bool Interacted;
    public GameObject IndLightOff;
    public GameObject NormLightOn;
    public ActivatingEndTrigger RockCollected;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Swoosh.Play();
            Interacted = true;
            FadeIn.SetTrigger("FadeIn");
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        Interacted = false;
        FadeOut.SetTrigger("FadeOut");
    }
    // Update is called once per frame
    void Update()
    {
        if(Interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                StartCoroutine(RubbleCollection());
                IEnumerator RubbleCollection()
                {
                    RockCollected.RockSample1 = true;
                    RockSmashNoise.SetActive(true);
                    thePlayer.GetComponent<FirstPersonController>().enabled = false;
                    FadeOut.SetTrigger("FadeOut");
                    rubbleSmoke.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rubbleSmoke.SetActive(false);
                    RockSmashNoise.SetActive(false);
                    IndLightOff.SetActive(false);
                    NormLightOn.SetActive(true);
                    Evidence.Play();
                    ItemAqcuired.SetActive(true);
                    ItemInventory1.SetActive(true);
                    thePlayer.GetComponent<FirstPersonController>().enabled = true;
                    Triggeroff.SetActive(false);

                }



            }





            
        }
    }
}
