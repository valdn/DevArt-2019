using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJ2ScriptRetour : MonoBehaviour {

    int direction = -1; //int direction where 0 is stay, 1 up, -1 down
    float left;
    float right;
    public float speed;

    private void Start()
    {
        left = transform.position.x;
        right = transform.position.x + 10;
    }

    void Update()
    {
        if (transform.position.x >= right)
            direction = 1;

        if (transform.position.x <= left)
            direction = -1;

        transform.Translate(speed * direction * Time.deltaTime, 0, 0);
    }
}
