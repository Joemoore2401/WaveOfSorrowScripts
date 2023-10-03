using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform teleportTarget;
    public GameObject thePlayer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            thePlayer.transform.position = teleportTarget.transform.position;
        }
        
        
    }

}
