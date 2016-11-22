using UnityEngine;
using System.Collections;

public class NavigationCtrlExit : MonoBehaviour {

	public void doExitGame() {
		Application.Quit();
		Debug.Log("Game is exiting");
	}


}
