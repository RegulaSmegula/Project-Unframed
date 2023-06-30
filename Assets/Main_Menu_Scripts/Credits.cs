using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public int Credits_Scene;

    public void Credit()
    {
        SceneManager.LoadScene(Credits_Scene);
    }
}
