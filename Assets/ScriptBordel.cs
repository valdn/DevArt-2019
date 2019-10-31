using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBordel : MonoBehaviour {

    int direction = 1; //int direction where 0 is stay, 1 up, -1 down
    float top;
    float bottom;
    public float speed;
    float rando;

    private void Start()
    {
        bottom = transform.position.y;
        top = transform.position.y + 2;
    }

    void Update()
    {
        rando = Random.Range(0, 2);
        if (rando == 0)
            rando = -1;
        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= bottom)
            direction = 1;

        transform.Translate(speed * rando * Time.deltaTime, speed * direction * Time.deltaTime, 0);
    }
}
