using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingFeature : MonoBehaviour
{


    public bool PickedUpMag;
    public bool Magnified = false;
    public GameObject NormCam;
    public GameObject LockpickLight;
    public GameObject UnNormCam;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject PointerArrow1;
    public GameObject PointerArrow2;
    public GameObject PointerArrow3;
    public GameObject PointerArrow4;
    public GameObject PointerArrow5;
    public GameObject PT2Light;
    public GameObject PT3Light;
    public GameObject PT1Light;
    public GameObject PT4Light;
    public GameObject Door4LightIndicator;
    public GameObject Door5LightIndicator;
    public GameObject Door2LightIndicator;
    public GameObject Door3LightIndicator;
    public GameObject Door1LightIndicator;
    public PT1Pickup spotlight;
    public PT2Pickup spotlight2;
    public PT3Pickup spotlight3;
    public PT4Pickup spotlight4;
    


    public bool MagnifiedObjects = false;
    // Update is called once per frame

    



    void Update()
    {



        if (Input.GetKeyDown(KeyCode.M))
        {

            if(PickedUpMag == true)
            {
                if (Magnified == true)
                {
                    CamResume();
                    LockpickLight.SetActive(false);                    
                    PT1Light.SetActive(false);
                    PT2Light.SetActive(false);
                    PT3Light.SetActive(false);
                    PT4Light.SetActive(false);
                    arrow1.SetActive(false);
                    arrow2.SetActive(false);
                    arrow3.SetActive(false);
                    PointerArrow1.SetActive(false);
                    PointerArrow2.SetActive(false);
                    PointerArrow3.SetActive(false);
                    PointerArrow4.SetActive(false);
                    PointerArrow5.SetActive(false);
                    Door4LightIndicator.SetActive(false);
                    Door2LightIndicator.SetActive(false);
                    Door5LightIndicator.SetActive(false);
                    Door3LightIndicator.SetActive(false);
                    Door1LightIndicator.SetActive(false);
                }
                else
                {

                    CamChanged();
                    LockpickLight.SetActive(true);
                    
                    PT1Light.SetActive(true);
                    PT2Light.SetActive(true);
                    PT3Light.SetActive(true);
                    PT4Light.SetActive(true);
                    arrow1.SetActive(true);
                    arrow2.SetActive(true);
                    arrow3.SetActive(true);
                    Door4LightIndicator.SetActive(true);
                    
                    if (spotlight.Spotlight == true)
                    {
                        Door4LightIndicator.SetActive(false);
                        arrow2.SetActive(false);
                        Door5LightIndicator.SetActive(true);
                        PointerArrow1.SetActive(true);
                        PointerArrow2.SetActive(true);
                    }
                    if (spotlight2.spotlight2 == true)
                    {
                        PointerArrow1.SetActive(false);
                        PointerArrow2.SetActive(false);
                        Door5LightIndicator.SetActive(false);
                        arrow1.SetActive(false);
                        Door2LightIndicator.SetActive(true);
                        PointerArrow3.SetActive(true);
                        PointerArrow4.SetActive(true);

                    }

                    if(spotlight3.spotlight3 == true)
                    {
                        PointerArrow3.SetActive(false);
                        PointerArrow4.SetActive(false);
                        Door2LightIndicator.SetActive(false);
                        Door3LightIndicator.SetActive(true);
                        PointerArrow5.SetActive(true);
                        
                    }

                    if(spotlight4.spotlight4 == true)
                    {
                        PointerArrow5.SetActive(false);
                        arrow3.SetActive(false);
                        Door3LightIndicator.SetActive(false);
                        Door1LightIndicator.SetActive(true);
                    }
                }

               


                
            }


           
        }
        
        
    }


    public void CamResume()
    {


        Magnified = false;
        MagnifiedObjects = false;
        NormCam.SetActive(true);
        UnNormCam.SetActive(false);
    }

    void CamChanged()
    {

        Magnified = true;
        MagnifiedObjects = false;
        NormCam.SetActive(false);
        UnNormCam.SetActive(true);
    }

}
