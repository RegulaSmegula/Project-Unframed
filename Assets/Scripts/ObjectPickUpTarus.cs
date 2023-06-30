using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUpTarus : MonoBehaviour
{
    public GameObject UsableObjectTarus;
    // Start is called before the first frame update
    void Start()
    {
        UsableObjectTarus.SetActive(false);
    }

 
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                UsableObjectTarus.SetActive(true);
            }
        }
    }
}
