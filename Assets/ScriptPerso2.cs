using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPerso2 : MonoBehaviour {

    public float time;
    public GameObject bubble;
    public GameObject text;
    public GameObject bubble1;
    public GameObject text1;
    public GameObject bubble2;
    public GameObject text2;
    public GameObject bubble3;
    public GameObject text3;

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

        bubble.SetActive(true);
        text.SetActive(true);

        yield return new WaitForSeconds(3);

        bubble.SetActive(false);
        text.SetActive(false);

        bubble1.SetActive(true);
        text1.SetActive(true);

        yield return new WaitForSeconds(3);

        bubble1.SetActive(false);
        text1.SetActive(false);

        bubble2.SetActive(true);
        text2.SetActive(true);

        yield return new WaitForSeconds(3);

        bubble2.SetActive(false);
        text2.SetActive(false);

        bubble3.SetActive(true);
        text3.SetActive(true);

        yield return new WaitForSeconds(3);

        script1.GetComponent<scroll>().isMove = true;
        script2.GetComponent<ScriptPerso>().isMove = true;
        script3.GetComponent<cameraMove>().isMove = true;
    }
}

