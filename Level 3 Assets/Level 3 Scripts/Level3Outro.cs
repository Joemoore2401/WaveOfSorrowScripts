using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Outro : MonoBehaviour
{
    public GameObject FPSOff;
    public GameObject FPSCam;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject Ambeinceoff;
    public GameObject Ambeinceon;
    public GameObject FadingWhite1;
    public GameObject FadingWhite2;
    public bool Entered;




    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Entered = true;

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Entered == true)
        {
            FPSCam.SetActive(false);
            FPSOff.SetActive(false);
            Ambeinceoff.SetActive(false);
            Ambeinceon.SetActive(true);
            cam1.SetActive(true);
            StartCoroutine(FPSSwitch());
            IEnumerator FPSSwitch()
            {
                
                yield return new WaitForSeconds(10);
                FadingWhite1.SetActive(true);
                yield return new WaitForSeconds(3);
                cam2.SetActive(true);
                yield return new WaitForSeconds(20);
                FadingWhite2.SetActive(true);
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene("TransLevel 3 4");
            }
        }

    }
}
