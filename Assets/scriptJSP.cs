using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptJSP : MonoBehaviour {

    public GameObject bubble;
    public GameObject text;

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        bubble.SetActive(true);
        text.SetActive(true);

        yield return new WaitForSeconds(3);

        bubble.SetActive(false);
        text.SetActive(false);
    }
}
