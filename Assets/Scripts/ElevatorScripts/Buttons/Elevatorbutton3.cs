using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevatorbutton3 : MonoBehaviour
{
    public GameObject Player;
    public string m_Scene3;
    public void PressForNextLevel()
    {
        // Press the space key to add the Scene additively and move the GameObject to that Scene
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        Player = GameObject.Find("PlayerCapsule(Clone)");
        StartCoroutine(LoadYourAsyncScene());
                IEnumerator LoadYourAsyncScene()
                {
                    // Set the current Scene to be able to unload it later
                    Scene currentScene = SceneManager.GetActiveScene();

                    // The Application loads the Scene in the background at the same time as the current Scene.
                    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_Scene3, LoadSceneMode.Additive);

                    // Wait until the last operation fully loads to return anything
                    while (!asyncLoad.isDone)
                    {
                        yield return null;
                    }

                    // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
                    SceneManager.MoveGameObjectToScene(Player, SceneManager.GetSceneByName(m_Scene3));
                    // Unload the previous Scene
                    Player.transform.position = new Vector3(-31, 0, 7);
                    SceneManager.UnloadSceneAsync(currentScene);
                }
    }
}
