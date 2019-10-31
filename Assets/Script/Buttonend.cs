using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttonend : MonoBehaviour {

    public GameObject task;
    public GameObject messageBox;
    public GameObject text1;
    public GameObject star;
    public GameObject pseudo;
    public GameObject msg;
    public GameObject closeButton;

    // Use this for initialization
    public void LoadMessage()
    {
        task.SetActive(true);
        messageBox.SetActive(true);
        closeButton.SetActive(true);
        text1.SetActive(false);
        star.SetActive(false);
        if (PlayerStats.getWinHack())
        {
            pseudo.SetActive(true);
            pseudo.GetComponent<Text>().text = PlayerStats.getPlayerPseudo() + " :";
            msg.SetActive(true);
            msg.GetComponent<Text>().text = PlayerStats.getPlayerMsg();
        }
        else
        {
            pseudo.GetComponent<Text>().text = "Hacker :";
            pseudo.SetActive(true);
            msg.GetComponent<Text>().text = "Vous n'avez pas reussi à contrer le hack, vos données nous appartiennent";
            msg.SetActive(true);
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
