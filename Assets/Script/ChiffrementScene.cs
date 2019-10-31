using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChiffrementScene : MonoBehaviour
{
    public Text discuss;
    private string userPseudo;
    private string userMsg;
    private string userMsgChiffre;
    private string userMsgBin;

    public void Start()
    {
        userMsg = PlayerStats.getPlayerMsg();
        userPseudo = PlayerStats.getPlayerPseudo();
        discuss = GameObject.Find("Discussion").GetComponent<Text>();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        discuss.text = "Bonjour je suis\nvotre donnée";
        yield return new WaitForSeconds(3);
        discuss.text = "Votre message est :\n" + userMsg;
        yield return new WaitForSeconds(3);
        setChiffre();
        discuss.text = "Chiffrement...\n" + userMsgChiffre;
        yield return new WaitForSeconds(3);
        userMsgBin = getBinaire();
        discuss.text = "Code binaire...\n" + userMsgBin;
        yield return new WaitForSeconds(3);
        discuss.text = "Le voyage de ce message\nva commencer";
        yield return new WaitForSeconds(3);

        PlayerStats.setPlayerMsgChiffre(userMsgChiffre);
        PlayerStats.setPlayerMsgBin(userMsgBin);

        SceneManager.LoadScene("GameScene");
    }

    void setChiffre()
    {
        Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);
        int decalage = 7;
        char[] chars = userMsg.ToCharArray();
        for(int i = 0; i < userMsg.Length; i++)
        {
            int c = chars[i];
            if('a' <= c && c <= 'z')
                c = 'a' + mod(c -'a' + decalage, 26);
            else if('A' <= c && c <= 'Z')
                c = 'A' + mod(c - 'A' + decalage, 26);
            else if('0' <= c && c <= '9')
                c = '0' + mod(c - '9' + decalage, 10);
            chars[i] = (char)c;
        }
    
        userMsgChiffre = new String(chars);
    }

    string getBinaire()
    {
        return StringToBinary(userMsgChiffre);
    }

    private static string StringToBinary(string data)
    {
        StringBuilder sb = new StringBuilder();
    
        foreach (char c in data.ToCharArray())
        {
            sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }
        return sb.ToString();
    }
}
