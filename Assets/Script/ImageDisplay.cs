using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ImageDisplay : MonoBehaviour
{
    public GameObject star;
    public GameObject task;
    public GameObject messageBox;
    public GameObject button;
    public GameObject text;
    public GameObject text1;
    public AudioSource sound;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        star.SetActive(false);
        task.SetActive(false);
        messageBox.SetActive(false);
        button.SetActive(false);
        text.SetActive(true);
        text1.SetActive(false);

        yield return new WaitForSeconds(7);

        star.SetActive(true);
        button.SetActive(true);
        text.SetActive(false);
        text1.SetActive(true);
        sound=gameObject.GetComponent<AudioSource>();
        sound.Play(0);
    }
}
