using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnStart : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioSource audioPlayer2;
    public AudioSource audioPlayer3;
    public float wait;
    public float wait2;
    void Start()
    {
        audioPlayer.PlayDelayed(1); 
        audioPlayer2.PlayDelayed(wait);
        audioPlayer3.PlayDelayed(wait2);
    }

}