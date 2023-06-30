using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilLevelFinishScript : MonoBehaviour
{
    public GameObject PipeFloorDone;
    public GameObject PipeWallDone;
    public GameObject PipeCorner1Done;
    public GameObject PipeCorner2Done;
    public GameObject PipeCrossDone;
    public GameObject ValveDone;
    public AudioSource audioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PipeFloorDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true && PipeWallDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true && PipeCorner1Done.GetComponent<ObjectGrabbable>().ObjectInPosition == true && PipeCorner2Done.GetComponent<ObjectGrabbable>().ObjectInPosition == true && PipeCrossDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true && ValveDone.GetComponent<ObjectGrabbable>().ObjectInPosition == true)
        {
            audioPlayer.Play();
        }
    }
}
