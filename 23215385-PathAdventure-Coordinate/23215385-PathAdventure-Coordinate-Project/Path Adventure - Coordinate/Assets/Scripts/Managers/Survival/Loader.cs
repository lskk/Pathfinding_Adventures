using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class Loader : MonoBehaviour {

	public GameObject gameManager;			//GameManager prefab to instantiate.
	public GameObject soundManager;			//SoundManager prefab to instantiate.
	//public static event UnityAction <Scene, LoadSceneMode> sceneLoaded;

	void Awake ()
	{
		//Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
		//if (GameManager.instance == null){
			//Instantiate gameManager prefab
			//Instantiate(gameManager);
		//}
		//Check if a SoundManager has already been assigned to static variable GameManager.instance or if it's still null
		if (SoundManager.instance == null)

			//Instantiate SoundManager prefab
			Instantiate(soundManager);

	}

	void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		if (GameManager.instance == null)
			Instantiate(gameManager);
	}
	void OnEnable()
	{
		//Tell our ‘OnLevelFinishedLoading’ function to start listening for a scene change event as soon as this script is enabled.
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}

	void OnDisable()
	{
		//Tell our ‘OnLevelFinishedLoading’ function to stop listening for a scene change event as soon as this script is disabled.
		//Remember to always have an unsubscription for every delegate you subscribe to!
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}

}
