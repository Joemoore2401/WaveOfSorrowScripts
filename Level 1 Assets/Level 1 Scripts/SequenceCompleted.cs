using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCompleted : MonoBehaviour
{

    public bool Civ1Rescued = false;
    public bool Civ2Rescued = false;
    public bool Civ3Rescued = false;
    public GameOverSegment countdownEnded;
    public GameObject Textoff;
    public GameObject BreakableRubbleActive;
    public GameObject Objective;
    

    // Update is called once per frame
    void Update()
    {
        if (Civ1Rescued == true)
        {
            if (Civ2Rescued == true)
            {
                if (Civ3Rescued == true)
                {
                    countdownEnded.countdownStop = true;
                    Textoff.SetActive(false);
                    BreakableRubbleActive.SetActive(true);
                    Objective.SetActive(true);
                }
            }
        }
    }
}
