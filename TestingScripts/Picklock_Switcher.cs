using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Picklock_Switcher : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PressE;
    public GameObject Lockpick;
    public GameObject fps;
    public static bool cold = false;
    public static bool Clicked = false;
    
    // Update is called once per frame
    void Update()
    {
       
        
            if (cold == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    STPlayer();
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }


            }
        

        
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);
            cold = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            cold = false;
        }

    }
    public void STPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        Time.timeScale = 0;
        Panel.SetActive(true);
        PressE.SetActive(false);
        cold = false;
    }
    public void SAPlayer()
    {
        Time.timeScale = 1;
        PressE.SetActive(false);
        Panel.SetActive(false);
        fps.GetComponent<FirstPersonController>().enabled = true;
        Lockpick.SetActive(false);
        cold = false;
        SceneManager.LoadScene("EndScene");
    }

}


