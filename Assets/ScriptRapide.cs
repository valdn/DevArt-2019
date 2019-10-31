using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRapide : MonoBehaviour {

    int direction = 1; //int direction where 0 is stay, 1 up, -1 down
    float right;
    int i;
    public float speed;

    private void Start()
    {
        i = 0;
    }

    void Update()
    {
        if (i>80)
            direction = 0;
            
        transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        i = i + 1;
    }
}
