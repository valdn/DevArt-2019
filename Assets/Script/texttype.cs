using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class texttype : MonoBehaviour
{

    public Text UIText;
    public string TextToType;
    public float TimeToType = 3.0f;

    private float textPercentage = 0;

    public void Update()
    {
        int numberOfLettersToShow = (int)(TextToType.Length * textPercentage);
        UIText.text = TextToType.Substring(0, numberOfLettersToShow);
        textPercentage += Time.deltaTime / TimeToType;
        textPercentage = Mathf.Min(1.0f, textPercentage);
    }
}
