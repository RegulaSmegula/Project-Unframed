using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUpCube : MonoBehaviour
{
    public GameObject UsableObject;
    // Start is called before the first frame update
    void Start()
    {
        UsableObject.SetActive(false);
    }

 
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                UsableObject.SetActive(true);
            }
        }
    }
}
