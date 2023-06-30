using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutDownScale : MonoBehaviour
{
    public GameObject ScaleOnPlayer;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ScaleOnPlayer.activeInHierarchy == true)
            { 
                if (Input.GetKey(KeyCode.E))
                    {
                        this.gameObject.GetComponent<Renderer>().enabled = true;

                        ScaleOnPlayer.SetActive(false);
                    }
            }
        }
    }
}