using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

    public GameObject direct;
    public float speed;
    private Vector3 positionDebut;
    public bool isMove;


    void Start () {
        positionDebut = transform.position;
        isMove = true;
    }
	

	void Update () {
        if (isMove)
            transform.position = Vector3.MoveTowards(transform.position, direct.transform.position, speed * Time.deltaTime);
    }
}
