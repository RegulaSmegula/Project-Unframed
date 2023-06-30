using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutDownCube : MonoBehaviour
{
    public GameObject CubeOnPlayer;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (CubeOnPlayer.activeInHierarchy == true)
            { 
                if (Input.GetKey(KeyCode.E))
                    {
                        this.gameObject.GetComponent<Renderer>().enabled = true;

                        CubeOnPlayer.SetActive(false);
                    }
            }
        }
    }
}