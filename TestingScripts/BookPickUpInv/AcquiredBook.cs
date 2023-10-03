using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcquiredBook : MonoBehaviour
{
    public BookUI Booked;
    public GameObject Book1Image;
    public GameObject PanelDelete;

    // Update is called once per frame
    void Update()
    {
        if(Booked.Acquired == true)
        {
            Book1Image.SetActive(true);

        }

        if(Booked.Acquired == false)
        {
            Book1Image.SetActive(false);

        }
    }


    public void Discard()
    {
        Booked.Acquired = false;
        Book1Image.SetActive(false);
        Destroy(PanelDelete);

        
    }
}
