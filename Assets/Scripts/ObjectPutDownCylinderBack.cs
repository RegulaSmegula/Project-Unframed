using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutDownCylinderBack : MonoBehaviour
{
    public GameObject CylinderBack;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (CylinderBack.activeInHierarchy == true)
            { 
                if (Input.GetKey(KeyCode.E))
                    {
                        this.gameObject.GetComponent<Renderer>().enabled = true;

                        CylinderBack.SetActive(false);
                    }
            }
        }
    }
}