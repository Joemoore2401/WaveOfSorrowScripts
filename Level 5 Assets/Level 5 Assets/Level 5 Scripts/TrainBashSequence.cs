using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class TrainBashSequence : MonoBehaviour
{
    public GameObject fps;
    public GameObject Cam1;
    public GameObject musicOff;
    public GameObject flowchart;
    public GameObject musicOn;
    public GameObject LocoOff;
    public GameObject explosion1;
    public GameObject explosion2;
    public Animator Loco;
    public GameObject LocoOn;
    public GameObject rocksOff;
    public GameObject rocksOn;
    public GameObject RubbleNoise;
    public GameObject whitePanel;
    public bool Done;
    
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Starting());

        IEnumerator Starting()
        {
            fps.GetComponent<FirstPersonController>().enabled = false;
            whitePanel.SetActive(true);
            yield return new WaitForSeconds(7);
            fps.SetActive(false);
            Cam1.SetActive(true);
            LocoOn.SetActive(true);
            LocoOff.SetActive(false);
            musicOff.SetActive(false);
            musicOn.SetActive(true);
            yield return new WaitForSeconds(3);
            Loco.SetTrigger("Loco1");
            yield return new WaitForSeconds(3);
            explosion1.SetActive(true);
            explosion2.SetActive(true);
            rocksOff.SetActive(false);
            rocksOn.SetActive(true);
            RubbleNoise.SetActive(true);
            yield return new WaitForSeconds(3);
            flowchart.SetActive(true);
            fps.SetActive(true);

        }
    }
}
