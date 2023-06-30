using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SceneLoader : MonoBehaviour
{
    public string CreditsPavlos; //scene name HERE

    public void LoadScene()
    {
        SceneManager.LoadScene(CreditsPavlos); //scene name HERE
    }
}
