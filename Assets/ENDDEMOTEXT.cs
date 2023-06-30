using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDDEMOTEXT : MonoBehaviour
{
    public GameObject ENDTEXT;
    public GameObject Button;

    private void OnTriggerEnter(Collider featherr)
    {
        if (featherr.gameObject.CompareTag("Feather"))
        {
            ENDTEXT.GetComponent<MeshRenderer>().enabled = true;
            Button.GetComponent<MeshRenderer>().enabled = true;
        }
    }

}
