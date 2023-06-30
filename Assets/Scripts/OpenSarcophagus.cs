using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSarcophagus : MonoBehaviour
{
    public GameObject SarcophagusTop;
    public GameObject FeatherBox;
    public Transform MoveLocation;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                SarcophagusTop.transform.position = MoveLocation.position;
                Debug.Log("Door has moved");
                FeatherBox.gameObject.GetComponent<MeshCollider>().enabled = true;
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}