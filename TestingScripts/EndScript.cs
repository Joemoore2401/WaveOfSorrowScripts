using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
   public void PlayAgain()
    
   {
        SceneManager.LoadScene("Blockout_Demo");
    
   }


    public void Quit()

    {
        Application.Quit();

    }
}
