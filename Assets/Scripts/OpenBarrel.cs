using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBarrel: MonoBehaviour
{
    public GameObject BarrelLid;
    public Transform MoveLocation;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                BarrelLid.transform.position = MoveLocation.position;
                Debug.Log("Lid is moved");
            }
        }
    }
}