using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerHacker : MonoBehaviour {

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
		  SceneManager.LoadScene("Hack-Phase");
    }
}
