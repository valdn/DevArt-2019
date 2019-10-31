using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFromScene : MonoBehaviour
{
 
    public void LoadScene()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {

        SceneManager.LoadScene("Chiffrage");
       // SceneManager.UnloadSceneAsync("Menu");

         yield return new WaitForSeconds(2);

        SceneManager.LoadScene("GameScene");
       // SceneManager.UnloadSceneAsync("Chiffrage");
    }
}
