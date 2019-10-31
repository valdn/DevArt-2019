using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScriptError : MonoBehaviour {

    public RawImage image;
    int direction = 1;
    float scale= (80f/255f);
    float speed = 0.2f;

    private void Start()
    {
       image=transform.GetComponent<RawImage>();
       image.color = new Color(255, 0, 0, scale);
    }

    void Update()
    {
        if (scale >= (80f / 255f))
            direction = -1;

        if (scale <= 0)
            direction = 1;

        scale = scale+speed * direction * Time.deltaTime;
        image.color = new Color(255, 0, 0, scale);
    }
}

