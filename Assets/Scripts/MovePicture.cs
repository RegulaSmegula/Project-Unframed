using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePicture: MonoBehaviour
{
    public AudioSource audioPlayer;
    public GameObject Portrait;
    public Transform MoveLocation;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Portrait.transform.position = MoveLocation.position;
                Debug.Log("Lid is moved");
                audioPlayer.Play();
            }
        }
    }
}