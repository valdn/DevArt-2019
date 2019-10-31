using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPNG : MonoBehaviour {
    int direction = -1; //int direction where 0 is stay, 1 up, -1 down
    float right;
    int i;
    public float speed;

    private void Start()
    {
        i = 0;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(3);

        if (i > 800)
            direction = 0;

        transform.Translate(speed * direction * Time.deltaTime, 0, 0);
        i = i + 1;
    }
}
