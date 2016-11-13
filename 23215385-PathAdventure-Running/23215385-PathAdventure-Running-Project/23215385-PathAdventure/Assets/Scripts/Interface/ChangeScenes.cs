using UnityEngine;
using System.Collections;

public class ChangeScenes : MonoBehaviour {

	//Call this methods for change scenes

	public void ChangeSceneToMenu() {
		Application.LoadLevel("MenuScene");
	}	

	public void ChangeSceneToGame() {
		Application.LoadLevel("GameScene");
	}

	public void ChangeSceneToEnd() {
		Application.LoadLevel("EndScene");
	}

	public void ChangeSceneToColorPicker() {
		Application.LoadLevel("ColorPickerScene");
	}
}