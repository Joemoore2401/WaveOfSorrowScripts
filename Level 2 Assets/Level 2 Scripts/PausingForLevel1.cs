using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class PausingForLevel1 : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject ThePlayer1;
    public GameObject ThePlayer2;
    public GameObject PauseMenuUI;
    public GameObject MusicOff;
    public GameObject MusicOn;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {




            if (GameIsPaused == true)
            {
                Resume();
                Cursor.visible = false;

            }
            else
            {

                Paused();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            }
        }
    }


    public void Resume()
    {

        Time.timeScale = 1;
        GameIsPaused = false;
        PauseMenuUI.SetActive(false);
        ThePlayer1.GetComponent<FirstPersonController>().enabled = true;
        ThePlayer2.GetComponent<FirstPersonController>().enabled = true;
        MusicOn.SetActive(false);
        MusicOff.SetActive(true);
    }

    void Paused()
    {
        Time.timeScale = 0;
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        ThePlayer1.GetComponent<FirstPersonController>().enabled = false;
        ThePlayer2.GetComponent<FirstPersonController>().enabled = false;
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
