using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerTrain : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Game");
    }

}
