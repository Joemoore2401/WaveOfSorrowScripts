using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerLevel3 : MonoBehaviour
{
    public int timer;
    public int timerStart;
    public GameObject ThePlayer;
    public bool countdownStop;



    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerStart;
        StartCountdown();
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = timer.ToString("0");

        Debug.Log("Time remaining: " + timer);





        if (timer == 0)
        {

            SceneManager.LoadScene("Level 3 GameOver");




            Debug.Log("Oh no!");




        }
    }



    public void StartCountdown()
    {
        Debug.Log("Countdown started");
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {

        yield return new WaitForSeconds(1f);

        if (!countdownStop)
        {
            timer--;

        }

        if (timer > 0 && !countdownStop)
        {
            StartCoroutine(Countdown());
        }

    }

}
