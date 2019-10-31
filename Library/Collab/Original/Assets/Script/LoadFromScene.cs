using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFromScene : MonoBehaviour
{
 
    public void LoadScene()
    {
        SceneManager.LoadScene("Chiffrage");

        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {

         yield return new WaitForSeconds(2);

        SceneManager.LoadScene("GameScene");
    }
}
