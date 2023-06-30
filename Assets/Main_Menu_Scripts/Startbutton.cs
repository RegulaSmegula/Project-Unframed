using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    public int Start_Scene;

    public void StartGame()
    {
        SceneManager.LoadScene(Start_Scene);
    }
}
