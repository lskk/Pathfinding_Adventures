using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour {

	public Text textToEdit;

	void Start () {
		//Update best score label (Get best score from PlayerPrefs)
		textToEdit.text = PlayerPrefs.GetInt("HighScore").ToString();
	}
}
