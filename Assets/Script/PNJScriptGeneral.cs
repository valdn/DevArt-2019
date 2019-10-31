using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJScriptGeneral : MonoBehaviour {

    int direction = -1; //int direction where 0 is stay, 1 up, -1 down
    float left;
    float right;
    float top;
    float bottom;
    int rando;
    public float speed;

    private void Start()
    {
        rando=Random.Range(1, 5);
        left = transform.position.x;
        right = transform.position.x + 10;
    }

    void Update()
    {
        if (rando == 1)
        {
            if (transform.position.x >= right)
                direction = 1;

            if (transform.position.x <= left)
                direction = -1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }
        if (rando == 2)
        {
            if (transform.position.x >= right)
                direction = -1;

            if (transform.position.x <= left)
                direction = 1;

            transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        }
        if (rando == 3)
        {
            if (transform.position.y >= top)
                direction = -1;

            if (transform.position.y <= bottom)
                direction = 1;

            transform.Translate(0, speed * direction * Time.deltaTime, 0);
        }
        if (rando == 4)
        {
            transform.Rotate(Vector3.forward * -5);
        }
    }
}
