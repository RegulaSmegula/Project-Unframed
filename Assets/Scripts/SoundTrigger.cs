using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    bool ToggleChange;
    public AudioSource audioPlayer;
    public AudioSource audioPlayer2;
    public AudioSource audioPlayer3;
    public AudioSource audioPlayerThatIDoNotWant;
    public float wait;
    public float wait2;

    public void Start()
    {
        ToggleChange = true;
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && ToggleChange == true &&!audioPlayerThatIDoNotWant.isPlaying)
        {
            ToggleChange = false;
            audioPlayer.Play();
            audioPlayer2.PlayDelayed(wait);
            audioPlayer3.PlayDelayed(wait2);
            Destroy(this.gameObject); 
        }
    }
}