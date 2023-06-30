using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteraction : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    private ObjectGrabbable ObjectGrabbable;
    public TextMeshProUGUI interactText;

    private void Start()
    {
        interactText.enabled = false;
    }
    private void Update()
    {
        float pickUpDistance = 12f;
        if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHitInteraction, pickUpDistance, pickUpLayerMask))
        {
            if (raycastHitInteraction.transform.TryGetComponent(out ObjectGrabbable))
            {
                interactText.enabled = true;
            }
            else
            {
                interactText.enabled = false;
            }
        }
    }
}
