using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackingPhase : MonoBehaviour {

	public GameObject QTE_cam;
    public GameObject Load_cam;
	public GameObject Qte_UI;
    public GameObject Load_UI;

	void Start () {
		Invoke("startQte", 5f);
	}
	
	public void startQte() {
		Qte_UI.SetActive(true);
		Load_UI.SetActive(false);
		QTE_cam.SetActive(true);
		Load_cam.SetActive(false);
	}

	public void endQte() {
		Qte_UI.SetActive(false);
		Load_UI.SetActive(true);
		QTE_cam.SetActive(false);
		Load_cam.SetActive(true);
	}

	public void setTextExpli(string str) {
		GameObject.Find("Text_explication").GetComponent<Text>().text = str;
	}
}
