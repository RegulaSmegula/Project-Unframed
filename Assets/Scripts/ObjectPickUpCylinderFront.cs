using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUpCylinderFront : MonoBehaviour
{
    public GameObject UsableObjectCylinderFront;
    // Start is called before the first frame update
    void Start()
    {
        UsableObjectCylinderFront.SetActive(false);
    }

 
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                UsableObjectCylinderFront.SetActive(true);
            }
        }
    }
}
