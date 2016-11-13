using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationCtrl : MonoBehaviour {

	public void LoadScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}

}
