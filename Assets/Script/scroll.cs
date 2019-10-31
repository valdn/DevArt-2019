using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    private float debutpos;
    public GameObject cam;
    public float parallax;
    public bool isMove;

    void Start () {
        debutpos = transform.position.x;
        isMove = true;
    }
	
	void Update () {
        if (isMove)
        {
            float dist = (cam.transform.position.x * parallax);
            transform.position = new Vector3(debutpos + dist, transform.position.y, transform.position.z);
        }
	}
}
