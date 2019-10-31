using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messagerie : MonoBehaviour {

	public GameObject textPseudo;

	// Use this for initialization
	void Start () {
		textPseudo.GetComponent<Text>().text = PlayerStats.getPlayerPseudo();
	}
}
