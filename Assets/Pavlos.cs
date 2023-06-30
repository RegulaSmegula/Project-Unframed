using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadPerson1Scene()
    {
        SceneManager.LoadScene(3);
    }

    // Will repeat for each person's scene
    // only change scene number.
}
