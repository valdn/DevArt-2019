using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QTESys : MonoBehaviour {

	public GameObject DisplayBox;
	private HackingPhase script;
	public int nbTour;
	int QTEGen;
	bool WaitingForKey;
	bool win;
	string key;

	void OnEnable() {
		win = true;
		WaitingForKey = true;
		script = GameObject.Find("script").GetComponent<HackingPhase>();
	}

	void Update() {
		if(WaitingForKey && nbTour > 0) {
			QTEGen = Random.Range(1,6);

			string letter = "";
			WaitingForKey = false;

			Invoke("changeLetter", 2f);

			switch(QTEGen) {
				case 1:
					letter = "[E]";
					break;
				case 2:
					letter = "[W]";
					break;
				case 3:
					letter = "[N]";
					break;
				case 4:
					letter = "[P]";
					break;
				case 5:
					letter = "[I]";
					break;
				default:
					break;
			}

			DisplayBox.GetComponent<Text>().text = letter;
		}

		switch(QTEGen) {
			case 1:
				key = "EKey";
				break;
			case 2:
				key = "WKey";
				break;
			case 3:
				key = "NKey";
				break;
			case 4:
				key = "PKey";
				break;
			case 5:
				key = "IKey";
				break;
			default:
				break;
		}
		StartCoroutine(onKeyPress());

		if(nbTour <= 0) {
			CancelInvoke();
			changeScene();
		}
	}

	IEnumerator onKeyPress() {
		if(Input.anyKeyDown) {
			WaitingForKey = true;
			CancelInvoke();
			DisplayBox.GetComponent<Text>().text = "";
			if(Input.GetButtonDown(key)) {
				win = win && true;
			} else {
				win = win && false;
			}
			nbTour--;
			yield return new WaitForSeconds(1f);
		}
	}

	void changeLetter() {
		win = false;
		WaitingForKey = true;
		nbTour--;
	}

	void changeScene() {
		PlayerStats.setWinHack(win);
		script.endQte();
		script.setTextExpli("Fini...\n\n\n\n\n\n\n\n\n\n");
		if(win)	SceneManager.LoadScene("Messagerie");
		else SceneManager.LoadScene("MessagerieError");
	}
}
