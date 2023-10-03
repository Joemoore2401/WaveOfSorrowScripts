using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanicedNoise : MonoBehaviour
{
    public GameObject Panic;
    public GameObject ObjectOff;
    public bool InZone;



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InZone = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
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
                Panic.SetActive(true);

                StartCoroutine(CivRise());

                IEnumerator CivRise()
                {
                    
                    yield return new WaitForSeconds(6);
                    ObjectOff.SetActive(false);


                }




            }
        }



    }


}
