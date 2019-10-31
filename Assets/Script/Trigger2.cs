using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{

    public GameObject script1;
    public GameObject script2;
    public GameObject script3;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        script1.GetComponent<scroll>().isMove = false;
        script2.GetComponent<ScriptPerso>().isMove = false;
        script3.GetComponent<cameraMove>().isMove = false;

        yield return new WaitForSeconds(3);

        script1.GetComponent<scroll>().isMove = true;
        script2.GetComponent<ScriptPerso>().isMove = true;
        script3.GetComponent<cameraMove>().isMove = true;
    }
}