using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutDownCylinderFront : MonoBehaviour
{
    public GameObject CylinderFront;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (CylinderFront.activeInHierarchy == true)
        {
            if (other.gameObject.tag == "Player")
            {
            
                if (Input.GetKey(KeyCode.E))
                    {
                        this.gameObject.GetComponent<Renderer>().enabled = true;

                        CylinderFront.SetActive(false);
                    }
            }
        }
    }
}