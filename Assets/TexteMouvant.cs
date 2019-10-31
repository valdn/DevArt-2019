using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexteMouvant : MonoBehaviour {

    public GameObject text;

// Update is called once per frame
void Update () {
    StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        text.SetActive(true);

        yield return new WaitForSeconds(3);

    }
}
