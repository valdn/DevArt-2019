using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DechiffrementScene : MonoBehaviour
{
    public Text discuss;
    private string userPseudo;
    private string userMsg;
    private string userMsgChiffre;
    private string userMsgBin;

    void Start()
    {
        userMsg = PlayerStats.getPlayerMsg();
        userPseudo = PlayerStats.getPlayerPseudo();
        userMsgChiffre = PlayerStats.getPlayerMsgChiffre();
        userMsgBin = PlayerStats.getPlayerMsgBin();
        discuss = GameObject.Find("Discussion").GetComponent<Text>();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        discuss.text = "Je suis arrivé à\ndestination";
        yield return new WaitForSeconds(3);
        discuss.text = "Le message en binaire est :\n" + userMsgBin;
        yield return new WaitForSeconds(3);
        discuss.text = "Le message chiffré est :\n" + userMsgChiffre;
        yield return new WaitForSeconds(3);
        discuss.text = "Déchiffrement...\n" + userMsg;
        yield return new WaitForSeconds(3);
        discuss.text = "Le voyage de ce messageest terminé\nNous allons arriver sur le PC de l'utilisateur...";
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Ending");
    }
}
