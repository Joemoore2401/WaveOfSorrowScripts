using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcquiredLog1 : MonoBehaviour
{
    public MagnifyingGlass Pickedup;
    public GameObject Book2Image;

    // Update is called once per frame
    void Update()
    {
        if (Pickedup.LogEntered == true)
        {
            Book2Image.SetActive(true);

        }

        if (Pickedup.LogEntered == false)
        {
            Book2Image.SetActive(false);

        }
    }


    public void Discard()
    {
        Pickedup.LogEntered = false;
        Book2Image.SetActive(false);


    }
}
