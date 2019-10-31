using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour {

    public float time;
    public GameObject bubble;
    public GameObject text;
    public GameObject npc;

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

        npc.SetActive(true);

        yield return new WaitForSeconds(2);

        bubble.SetActive(false);
        text.SetActive(false);

        script1.GetComponent<scroll>().isMove = true;
        script2.GetComponent<ScriptPerso>().isMove = true;
        script3.GetComponent<cameraMove>().isMove = true;
    }
}
