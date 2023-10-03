using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceTrigger : MonoBehaviour
{
    public AudioSource VoiceNote;
    public GameObject Triggeroff;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(TimePlaying());
            IEnumerator TimePlaying()
            {
                VoiceNote.Play();
                yield return new WaitForSeconds(6);
                Triggeroff.SetActive(false);

            }
        }
    }
}
