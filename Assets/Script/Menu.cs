using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public InputField pseudoInputField;
    public InputField msgInputField;
    public GameObject mainCanvas;
    public GameObject creditsCanvas;

    static bool credits;

    void Start()
    {
        credits = false;
    }

    public void LoadScene()
    {
        StartCoroutine(chiffrage());
    }

    IEnumerator chiffrage()
    {
        if(pseudoInputField.text == "") {
            pseudoInputField.text = "Igor";
        }
        if(msgInputField.text == "") {
            msgInputField.text = "Tu es beau";
        }

        PlayerStats.setPlayerPseudo(pseudoInputField.text);
        PlayerStats.setPlayerMsg(msgInputField.text);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Chiffrage");
    }

    public void ToggleCanvas()
    {
        StartCoroutine(toggle());
    }

    IEnumerator toggle() 
    {
        yield return new WaitForSeconds(0.5f);
        mainCanvas.SetActive(credits);
        creditsCanvas.SetActive(!credits);
        credits = !credits;
    }

    public void quitterApp() {
        StartCoroutine(quit());
    }

    IEnumerator quit() 
    {
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}

public static class PlayerStats
{
    private static string playerPseudo;
    private static string playerMsg;
    private static string playerMsgChiffre;
    private static string playerMsgBin;
    private static bool winHack;

    public static void setPlayerPseudo(string value) {
        playerPseudo = value;
    }

    public static string getPlayerPseudo() {
        return playerPseudo;
    }


    public static void setPlayerMsg(string value) {
        playerMsg = value;
    }

    public static string getPlayerMsg() {
        return playerMsg;
    }


    public static void setPlayerMsgChiffre(string value) {
        playerMsgChiffre = value;
    }

    public static string getPlayerMsgChiffre() {
        return playerMsgChiffre;
    }


    public static void setPlayerMsgBin(string value) {
        playerMsgBin = value;
    }

    public static string getPlayerMsgBin() {
        return playerMsgBin;
    }


    public static void setWinHack(bool value) {
        winHack = value;
    }

    public static bool getWinHack() {
        return winHack;
    }
}