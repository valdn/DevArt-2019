using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {

    public GameObject bubble;
    public GameObject text;

    void OnTriggerEnter2D(Collider2D collision)
    {
        bubble.SetActive(true);
        text.SetActive(true);
    }
}
