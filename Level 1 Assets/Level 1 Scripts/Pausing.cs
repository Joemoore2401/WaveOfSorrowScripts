using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Pausing: MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject ThePlayer;
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
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        MusicOn.SetActive(false);
        MusicOff.SetActive(true);
    }

    void Paused()
    {
        Time.timeScale = 0;
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
    
}
