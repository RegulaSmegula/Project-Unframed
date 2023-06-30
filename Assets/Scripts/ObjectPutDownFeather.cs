using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutDownFeather : MonoBehaviour
{
    public GameObject FeatherOnPlayer;
    public GameObject HeartOnScale;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (FeatherOnPlayer.activeInHierarchy == true)
            { 
                if (Input.GetKey(KeyCode.E))
                    {
                        this.gameObject.GetComponent<Renderer>().enabled = true;

                        FeatherOnPlayer.SetActive(false);
                        HeartOnScale.gameObject.GetComponent<Renderer>().enabled = true;
                    }
            }
        }
    }
}