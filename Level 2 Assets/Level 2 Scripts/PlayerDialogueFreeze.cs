using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PlayerDialogueFreeze : MonoBehaviour
{
    public GameObject fps;
    public bool CursorActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CursorActive == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void StopPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        CursorActive = true;
    }

    public void StartPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = true;
        CursorActive = false;
    }
}
