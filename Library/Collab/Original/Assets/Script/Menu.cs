using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public InputField mainInputField;

    public void LoadScene()
    {
        mainInputField = GameObject.Find("InputField").GetComponent<InputField>();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        PlayerStats.setPlayerMsg(mainInputField.text);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Ending");
    }
}

public static class PlayerStats
{
    private static string playerMsg;
    private static string playerPseudo;

    public static void setPlayerMsg(string value) {
        playerMsg = value;
    }

    public static string getPlayerMsg() {
        return playerMsg;
    }

    public static void setPlayerPseudo(string value) {
        playerPseudo = value;
    }

    public static string getPlayerPseudo() {
        return playerPseudo;
    }
}