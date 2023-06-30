using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerScript : MonoBehaviour
{
    public GameObject Player;
    private ConsistentBool ConsistentBool;
    public AudioSource audioPlayer;
    public GameObject ArtWork;
    // Start is called before the first frame update
    void Awake()
    {
        if (ConsistentBool.HasPlayerBeen == false)
        {
            Instantiate(Player, new Vector3(228.3f, 5.09f, 334.2f), Quaternion.identity);
            ConsistentBool.HasPlayerBeen = true;
        }
        else
        {
            Debug.Log("whipnaenae");
            audioPlayer.Play();
            ArtWork.GetComponent<MeshRenderer>().enabled = true;

        }
    }
}
