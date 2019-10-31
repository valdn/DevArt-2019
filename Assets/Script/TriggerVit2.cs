using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVit2 : MonoBehaviour {

    public GameObject script1;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        script1.GetComponent<cameraMove>().speed = -40;
    }
}
