
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    private ObjectGrabbable ObjectGrabbable;
    public Elevatorbutton1 Elevatorbutton1;
    public Elevatorbutton2 Elevatorbutton2;
    public Elevatorbutton3 Elevatorbutton3;
    public ReturnButton ReturnButton;

    private void Update()
    {
        float pickUpDistance = 12f;
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ObjectGrabbable == null) 
            { 
                //Not carrying an object, try to grab it
                
                if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask))
                {
                    if (raycastHit.transform.TryGetComponent(out ObjectGrabbable))
                    {
                        ObjectGrabbable.Grab(objectGrabPointTransform);
                        Debug.Log(ObjectGrabbable);
                    }
                    if (raycastHit.transform.TryGetComponent(out Elevatorbutton1))
                    {
                        Elevatorbutton1.PressForNextLevel();
                        Debug.Log(Elevatorbutton1);
                    }
                    if (raycastHit.transform.TryGetComponent(out Elevatorbutton2))
                    {
                        Elevatorbutton2.PressForNextLevel();
                        Debug.Log(Elevatorbutton2);
                    }
                    if (raycastHit.transform.TryGetComponent(out Elevatorbutton3))
                    {
                        Elevatorbutton3.PressForNextLevel();
                        Debug.Log(Elevatorbutton3);
                    }
                }
            } else if (ObjectGrabbable.ObjectInPosition == false)
                {
                //Currently carrying something, drop it
                ObjectGrabbable.Drop();
                ObjectGrabbable = null;
                }
        }
        if (ObjectGrabbable != null && ObjectGrabbable.ObjectInPosition == true) 
        { 
            if (Input.GetKeyDown (KeyCode.E)) 
            {
                ObjectGrabbable.ObjectFinish();
                ObjectGrabbable = null;
            }
        }
    }

}
