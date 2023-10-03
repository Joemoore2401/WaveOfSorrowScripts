using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndInteraction : MonoBehaviour
{
    public GameObject CamActive;
    public GameObject Rocksgone;
    public GameObject FPS;
    public GameObject musicOff;
    public GameObject musicOn;
    public AudioSource Swoosh;
    public Animator FadeIn;
    public Animator FadeOut;
    public GameObject Smoke;
    public GameObject fadeWhite;
    public Animator TrainMove;
    public bool InArea;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InArea = true;
            Swoosh.Play();
            FadeIn.SetTrigger("FadeIn");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        InArea = false;
        FadeOut.SetTrigger("FadeOut");
    }


    void Update()
    {
        if(InArea == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(EndSequence());
                IEnumerator EndSequence()
                {
                    FadeOut.SetTrigger("FadeOut");
                    Rocksgone.SetActive(true);
                    Smoke.SetActive(true);
                    musicOff.SetActive(false);
                    musicOn.SetActive(true);
                    FPS.SetActive(false);
                    CamActive.SetActive(true);
                    yield return new WaitForSeconds(5);
                    TrainMove.SetTrigger("TrainMove");
                    yield return new WaitForSeconds(5);
                    fadeWhite.SetActive(true);
                    yield return new WaitForSeconds(2);
                    SceneManager.LoadScene("TransLevel 4 5");
                }
            }
        }
    }
}
