using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PauseBoolScript : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject ThePlayer;
    public GameObject PauseMenuUI;
    public GameObject MusicOn;
    public GameObject PlayerActive;
    public GameObject camActive;
    public bool Activate = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if(Activate == true)
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
    }


    public void Resume()
    {

        Time.timeScale = 1;
        GameIsPaused = false;
        PauseMenuUI.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        MusicOn.SetActive(false);
        PlayerActive.SetActive(true);
        camActive.SetActive(false);
    }

    void Paused()
    {
        Time.timeScale = 0;
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        MusicOn.SetActive(true);
        PlayerActive.SetActive(false);
        camActive.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
