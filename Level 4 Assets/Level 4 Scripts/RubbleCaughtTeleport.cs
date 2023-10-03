using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class RubbleCaughtTeleport : MonoBehaviour
{
    public GameObject FPS;
    public GameObject TunnelOff;
    public GameObject Rubbletriggeroff;
    public GameObject whiteFadeIn;
    public Transform teleportTarget;
    public GameObject OldMan;
    public GameObject Flowchart;
    public GameObject musicoff;
    public GameObject musicon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            whiteFadeIn.SetActive(true);
            FPS.transform.position = teleportTarget.transform.position;
            Rubbletriggeroff.SetActive(false);
            Flowchart.SetActive(true);
            OldMan.SetActive(true);
            TunnelOff.SetActive(false);
            musicoff.SetActive(false);
            musicon.SetActive(true);
        }
    }
}
