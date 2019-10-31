using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJScript1 : MonoBehaviour {

    int direction = 1; //int direction where 0 is stay, 1 up, -1 down
    float top;
    float bottom;
    float speed = 2;

    private void Start()
    {
        bottom = transform.position.y;
        top = transform.position.y + 2;
    }

    void Update()
    {
        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= bottom)
            direction = 1;

        transform.Translate(0, speed * direction * Time.deltaTime, 0);
    }
}
