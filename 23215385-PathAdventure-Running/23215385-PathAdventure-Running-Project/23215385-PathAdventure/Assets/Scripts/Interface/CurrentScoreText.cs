using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentScoreText : MonoBehaviour {
	
	public Text textToEdit;
	
	void Start () {
		//Update current score label (Get best score from PlayerPrefs)
		textToEdit.text = PlayerPrefs.GetInt("CurrentScore").ToString();
	}
}
