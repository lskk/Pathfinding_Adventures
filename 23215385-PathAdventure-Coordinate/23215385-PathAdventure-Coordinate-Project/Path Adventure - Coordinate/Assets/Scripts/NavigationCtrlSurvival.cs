using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavigationCtrlSurvival : MonoBehaviour {

	public void LoadScene(string sceneName){
		GameManager.instance.GameOver ();
		//SceneManager.LoadScene (sceneName);
	}

}
