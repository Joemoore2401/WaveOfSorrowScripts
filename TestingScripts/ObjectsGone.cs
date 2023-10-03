using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGone : MonoBehaviour
{
    public GameObject PT4;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject PressE;
    public GameObject LockpickActive;
    public GameObject Door1Active;
    public bool spotlight4 = false;
    public static bool Raided = false;
    public PTSActive pts1;
    public PTSActive pts2;
    public PTSActive pts3;

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
             Raided = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
             Raided = false;
        }
    }


    void Update()
    {
        if (Raided == true)
        {
            
                    
            if (Input.GetKeyDown(KeyCode.E))
            {


                


                PressE.SetActive(false);
                Image1.SetActive(false);
                Image2.SetActive(false);
                Image3.SetActive(false);
                LockpickActive.SetActive(true);
                spotlight4 = true;
                Door1Active.SetActive(true);
                pts1.PT1L = false;
                pts2.PT2L = false;
                pts3.PT3L = false;
                PT4.SetActive(false);

            }
                        
                        
                    
                
            
        }
        
        
        
    }
}
