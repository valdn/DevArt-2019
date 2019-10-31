using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnding : MonoBehaviour {

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
		  SceneManager.LoadScene("Dechiffrage");
    }
}
