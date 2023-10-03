using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BitPaused : MonoBehaviour
{
    public GameObject fps;
    public GameObject PausePanel;
    public static bool thatPause = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(thatPause == true)
            {
                NotPaused();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        else
        {
            NowPaused();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


    public void NowPaused()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        thatPause = true;
    }
    public void NotPaused()
    {
        fps.GetComponent<FirstPersonController>().enabled = true;
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        thatPause = false;
       
    }
}
