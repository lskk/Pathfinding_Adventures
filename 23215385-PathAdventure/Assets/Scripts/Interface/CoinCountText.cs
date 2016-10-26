using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCountText : MonoBehaviour {

	public Text textToEdit;

	void Start () {
		//Update best score label (Get best score from PlayerPrefs)
		textToEdit.text = PlayerPrefs.GetInt("Coin").ToString();
	}
}
