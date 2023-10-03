using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PauseMechanic : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject ThePlayer;
    public GameObject PauseMenuUI;
    public GameObject PauseNoise;
    public GameObject DisableNoise2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {




            if (GameIsPaused == true)
            {
                 
                

                
                    Resume();
                    Cursor.lockState = CursorLockMode.Locked;
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

        

            Time.timeScale = 1f;
            GameIsPaused = false;
        PauseNoise.SetActive(false);
        DisableNoise2.SetActive(true);
        PauseMenuUI.SetActive(false);
            ThePlayer.GetComponent<FirstPersonController>().enabled = true;




        

       
    }

    void Paused()
    {

        
      
            Time.timeScale = 0f;
            GameIsPaused = true;
        PauseNoise.SetActive(true);
        DisableNoise2.SetActive(false);
        PauseMenuUI.SetActive(true);
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;



        

    }

    public void Quit()
    {
        Application.Quit();
    }
}
