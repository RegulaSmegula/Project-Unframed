using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    public bool ObjectInPosition = false;
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    private Transform ObjectFinishPoint;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        objectRigidbody.useGravity = false;
    }
    public void Drop()
    {
       this.objectGrabPointTransform = null;
       objectRigidbody.useGravity = true;
        objectRigidbody.isKinematic = false;
    }



    public void ObjectFinish()
    {
        this.objectGrabPointTransform = null;
        Vector3 ObjectFinishPosition = ObjectFinishPoint.position;
        Quaternion ObjectFinishRotation = ObjectFinishPoint.rotation;
        this.transform.SetPositionAndRotation(ObjectFinishPosition, ObjectFinishRotation);
        objectRigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }

    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null) 
        {
            float lerpSpeed = 6f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger")) 
        {
            //Make it so that it only triggers on the correct options
            ObjectFinishPoint = other.GetComponent<Transform>();
            ObjectInPosition = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        { 
            ObjectInPosition = false;
        }
    }
}
