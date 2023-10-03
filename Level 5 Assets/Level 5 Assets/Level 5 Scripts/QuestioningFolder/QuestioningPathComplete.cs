using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestioningPathComplete : MonoBehaviour
{
    public bool Questioned1;
    public bool Questioned2;
    public bool Questioned3;
    public bool Questioned4;
    public bool Questioned5;
    public GameObject LightOn1;
    public GameObject LightOn2;
    public GameObject LightOff1;
    public GameObject LightOff2;
    public GameObject Flowchart;



    private void Update()
    {
        if (Questioned1 == true)
        {
            if (Questioned2 == true)
            {
                if (Questioned3 == true)
                {
                    if (Questioned4 == true)
                    {
                        if (Questioned5 == true)
                        {
                            Flowchart.SetActive(true);
                            LightOff1.SetActive(false);
                            LightOff2.SetActive(false);
                            LightOn1.SetActive(true);
                            LightOn2.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
