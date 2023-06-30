using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPosition : MonoBehaviour
{
    public bool ObjectFinalPosition = false;

    // Update is called once per frame

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            ObjectFinalPosition = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            ObjectFinalPosition = false;
        }
    }
}
