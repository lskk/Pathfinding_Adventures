using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerColorSelector : MonoBehaviour {

	public Text labelCoin;
	public int currentColorNumber;

	void OnMouseDown () {
		if (currentColorNumber == 0) {
			PlayerPrefs.SetInt("Current color theme", currentColorNumber);
		}
		if (currentColorNumber == 1) {
			if (PlayerPrefs.GetInt("Color1Avaliable") == 1) {
				PlayerPrefs.SetInt("Current color theme", currentColorNumber);
			}
			else {
				if (PlayerPrefs.GetInt("Coin") > 50) {
					PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - 50);
					PlayerPrefs.SetInt("Color1Avaliable", 1);
				}
			}
		}
		if (currentColorNumber == 2) {
			if (PlayerPrefs.GetInt("Color2Avaliable") == 1) {
				PlayerPrefs.SetInt("Current color theme", currentColorNumber);
			}
			else {
				if (PlayerPrefs.GetInt("Coin") > 50) {
					PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - 50);
					PlayerPrefs.SetInt("Color2Avaliable", 1);
				}
			}
		}		
		if (currentColorNumber == 3) {
			if (PlayerPrefs.GetInt("Color3Avaliable") == 1) {
				PlayerPrefs.SetInt("Current color theme", currentColorNumber);
			}
			else {
				if (PlayerPrefs.GetInt("Coin") > 50) {
					PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - 50);
					PlayerPrefs.SetInt("Color3Avaliable", 1);
				}
			}
		}
	}

	void Update () {
		if (currentColorNumber == PlayerPrefs.GetInt("Current color theme")) {
			gameObject.transform.localScale = new Vector3(2.75F, 2.75F, 2.75F);
		}
		else {
			gameObject.transform.localScale = new Vector3(2.0F, 2.0F, 2.0F);
		}

		//Update coin balanse
		labelCoin.text = PlayerPrefs.GetInt("Coin").ToString();
	}
}
