using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Menu_Scene;

    public void Menu()
    {
        SceneManager.LoadScene(Menu_Scene);
    }
}
