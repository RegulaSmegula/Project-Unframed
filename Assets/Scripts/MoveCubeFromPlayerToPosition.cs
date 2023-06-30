using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeFromPlayerToPosition : MonoBehaviour
{
    public GameObject CubeInDoor;
    public GameObject CubeOutDoor;
    private Vector3 CubeOutDoorPosition;
    private Vector3 CubeInDoorPosition;
    // Start is called before the first frame update

    private void Update()
    {
        CubeOutDoorPosition = CubeOutDoor.transform.position;
        CubeInDoorPosition = CubeInDoor.transform.position;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "FinishedCube")
        {
            if (Input.GetKey(KeyCode.E))
            {
                transform.position = Vector3.MoveTowards(CubeOutDoorPosition, CubeInDoorPosition, 1000);
                Debug.Log("Moving Object RN Gamer.");
            }
        }
    }

}
