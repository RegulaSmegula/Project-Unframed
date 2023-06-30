using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSingleTrigger : MonoBehaviour
{
    bool ToggleChange;
    public AudioSource OtherOne;
    public AudioSource AnotherOne;
    public AudioSource audioPlayer;

    public void Start()
    {
        ToggleChange = true;
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && ToggleChange == true && !OtherOne.isPlaying && !AnotherOne.isPlaying)
        {
            ToggleChange = false;
            audioPlayer.Play();
        }
    }
}