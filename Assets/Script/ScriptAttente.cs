using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAttente : MonoBehaviour {

    public GameObject text;
    public float time;

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(time);

        text.SetActive(true);

    }
}
