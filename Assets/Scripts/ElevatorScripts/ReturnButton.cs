using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public string m_Scene;
    private GameObject Player;
    //public GameObject anchieboy;
    public void OnTriggerStay(Collider other)
    {
        Player = GameObject.Find("PlayerCapsule(Clone)");
        if (other.gameObject.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                // Press the space key to add the Scene additively and move the GameObject to that Scene
                StartCoroutine(LoadYourAsyncScene());
                IEnumerator LoadYourAsyncScene()
                {
                    // Set the current Scene to be able to unload it later
                    Scene currentScene = SceneManager.GetActiveScene();

                    // The Application loads the Scene in the background at the same time as the current Scene.
                    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_Scene, LoadSceneMode.Additive);

                    // Wait until the last operation fully loads to return anything
                    while (!asyncLoad.isDone)
                    {
                        yield return null;
                    }

                    // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
                    SceneManager.MoveGameObjectToScene(Player, SceneManager.GetSceneByName(m_Scene));
                    //SceneManager.MoveGameObjectToScene(anchieboy, SceneManager.GetSceneByName(m_Scene));
                    // Unload the previous Scene
                    Player.transform.position = new Vector3(177, 9.1f, 331.6f);
                    //anchieboy.transform.position = new Vector3(184.58f, 11.252f, 331.47f);
                    SceneManager.UnloadSceneAsync(currentScene);
                }
            }
        }
    }
}
