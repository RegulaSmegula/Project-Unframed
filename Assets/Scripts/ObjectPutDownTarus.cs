using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPutDownTarus : MonoBehaviour
{
    public GameObject Tarus;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (Tarus.activeInHierarchy == true)
        {
            if (other.gameObject.tag == "Player")
            {

                    if (Input.GetKey(KeyCode.E))
                        {
                            this.gameObject.GetComponent<Renderer>().enabled = true;

                            Tarus.SetActive(false);
                        }

            }
        }
    }
}