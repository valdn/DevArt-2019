using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPNJspawn : MonoBehaviour {

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        p1.SetActive(true);
        p2.SetActive(true);
        p3.SetActive(true);
        p4.SetActive(true);
        p5.SetActive(true);
    }
}
