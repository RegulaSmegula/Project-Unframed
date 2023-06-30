using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUpCylinderBack : MonoBehaviour
{
    public GameObject UsableObjectCylinderBack;
    // Start is called before the first frame update
    void Start()
    {
        UsableObjectCylinderBack.SetActive(false);
    }

 
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                UsableObjectCylinderBack.SetActive(true);
            }
        }
    }
}
