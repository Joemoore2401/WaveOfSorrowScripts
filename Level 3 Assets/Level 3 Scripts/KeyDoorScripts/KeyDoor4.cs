using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor4 : MonoBehaviour
{
    public bool InsideTrigger;
    public Animator LockOpen;
    public GameObject Triggeroff;
    public GameObject IndicatorLight;
    public GameObject NormLight;
    public AudioSource Swoosh;
    public GameObject DoorOpen;
    public GameObject evidencetrigger;
    public Animator FadeIn;
    public Animator Fadeout;
    public GameObject ItemImage;
    public bool KeyPickedUp4 = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FadeIn.SetTrigger("FadeIn");
            Swoosh.Play();
            InsideTrigger = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Fadeout.SetTrigger("FadeOut");
        InsideTrigger = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (InsideTrigger == true)
        {

            if (KeyPickedUp4 == true)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    StartCoroutine(Sequence());
                    IEnumerator Sequence()
                    {
                        Fadeout.SetTrigger("FadeOut");
                        LockOpen.SetTrigger("Chest4");
                        IndicatorLight.SetActive(false);
                        NormLight.SetActive(true);
                        DoorOpen.SetActive(true);
                        ItemImage.SetActive(false);
                        yield return new WaitForSeconds(2);
                        Triggeroff.SetActive(false);
                        evidencetrigger.SetActive(true);

                    }

                }
            }


        }
    }
}
