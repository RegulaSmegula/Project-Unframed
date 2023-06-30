using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public string m_Scene;
    public GameObject Player;


    //    private void OnTriggerStay(Collider other)
    //    {
    //    Scene currenScene = SceneManager.GetActiveScene(); 
    //                if (other.gameObject.tag == "Player")
    //                {
    //
    //                        if (Input.GetKey(KeyCode.E))
    //                        {
    //                              SceneManager.MoveGameObjectToScene(Player, SceneManager.GetSceneByName(Egyptian_Puzzle));
    //                              SceneManager.UnloadSceneAsync(currenScene);
    //                        }
    //                }
    //    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Press the space key to add the Scene additively and move the GameObject to that Scene
            if (Input.GetKeyDown(KeyCode.E))
            {
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
                    // Unload the previous Scene
                    Player.transform.position = new Vector3(218, 4, 276);
                    SceneManager.UnloadSceneAsync(currentScene);
                }
            }
        }
    }


}
