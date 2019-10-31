using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJRotation : MonoBehaviour {

    private void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.forward * -5);
    }
}
