using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbleChase : MonoBehaviour
{
    public GameObject BlockedAreaOff;
    public GameObject RunObjective;
    public GameObject RubbleDisplayOff;
    public GameObject Rubble1;
    public GameObject Rubble2;
    public GameObject Rubble3;
    public bool Interacted;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Interacted = true;
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Interacted = false;
        }
    }
    void Update()
    {
       if(Interacted == true)
       {
            StartCoroutine(Rubbling());

            IEnumerator Rubbling()
            {
                RubbleDisplayOff.SetActive(false);
                Rubble1.SetActive(true);
                RunObjective.SetActive(true);
                yield return new WaitForSeconds(20);
                Rubble1.SetActive(false);
                Rubble2.SetActive(true);
                yield return new WaitForSeconds(12);
                Rubble2.SetActive(false);
                Rubble3.SetActive(true);
                yield return new WaitForSeconds(8);
            }
       }
    }
}
