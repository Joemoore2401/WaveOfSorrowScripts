using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class StartingSequence : MonoBehaviour
{
    public GameObject fps;
    public GameObject CamOff;
    public GameObject musicOff;
    public PauseBoolScript Active;
    public GameObject musicOn;
    public GameObject ObjectivePanel;
    public GameObject hint;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Starting());

        IEnumerator Starting()
        {
            yield return new WaitForSeconds(10);
            Active.Activate = true;           
            fps.SetActive(true);
            CamOff.SetActive(false);
            musicOff.SetActive(false);
            musicOn.SetActive(true);
            ObjectivePanel.SetActive(true);
            hint.SetActive(true);
            
        }
    }
}
