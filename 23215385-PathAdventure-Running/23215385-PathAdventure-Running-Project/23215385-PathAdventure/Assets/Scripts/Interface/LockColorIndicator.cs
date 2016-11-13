using UnityEngine;
using System.Collections;

public class LockColorIndicator : MonoBehaviour {

	public int currentColorNumber;

	void Update () {
		if (currentColorNumber == 1) {
			if (PlayerPrefs.GetInt("Color1Avaliable") == 1) {
				Destroy(gameObject);
			}
		}
		if (currentColorNumber == 2) {
			if (PlayerPrefs.GetInt("Color2Avaliable") == 1) {
				Destroy(gameObject);
			}
		}		
		if (currentColorNumber == 3) {
			if (PlayerPrefs.GetInt("Color3Avaliable") == 1) {
				Destroy(gameObject);
			}
		}
	}
}
