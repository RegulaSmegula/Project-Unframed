using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePuzzleDoor : MonoBehaviour
{
    public GameObject OctagonDone;
    public GameObject HexagonDone;
    public GameObject CubeDone;
    public GameObject TarusDone;
    public GameObject Door;
    public Transform DoorFinish;
    public AudioSource audioPlayer;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        OctagonDone.GetComponent<ObjectGrabbable>();
        TarusDone.GetComponent<ObjectGrabbable>();
        CubeDone.GetComponent<ObjectGrabbable>();
        HexagonDone.GetComponent<ObjectGrabbable>();
        Door.GetComponent<Transform>();
        if (other.gameObject.tag == "Player")
        {
            if (OctagonDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true && HexagonDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true && CubeDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true && TarusDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Vector3 DoorFinalPosition = Vector3.MoveTowards(Door.transform.position, DoorFinish.position, 10f);
                    Door.transform.position = DoorFinalPosition;
                    Debug.Log("Door has moved");
                    audioPlayer.Play();
                }
            }
        }
    }
}