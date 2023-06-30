using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSarcophagus : MonoBehaviour
{
    public GameObject SarcophagusTop;
    public GameObject SarcoText;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            {
                SarcophagusTop.gameObject.GetComponent<BoxCollider>().enabled = true;
                SarcoText.gameObject.GetComponent<MeshRenderer>().enabled = true;
                Debug.Log("Sarco collid enabled");
            }
        }
    }
}