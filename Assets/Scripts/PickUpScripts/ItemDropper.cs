using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropper : MonoBehaviour
{
    public GameObject PipeAngledLeft; // The prefab of the item you want to drop
    public Transform PipeAngledLeftPos; // The specific location where you want to drop the item


    public void DropItem()
    {
        GameObject PipePosition = Instantiate(PipeAngledLeft, PipeAngledLeftPos.position, PipeAngledLeftPos.rotation);
        // Set any additional properties or configurations for the dropped item here
    }
}