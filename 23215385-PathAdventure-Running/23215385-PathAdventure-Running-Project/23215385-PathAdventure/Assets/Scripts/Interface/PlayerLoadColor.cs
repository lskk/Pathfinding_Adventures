using UnityEngine;
using System.Collections;

public class PlayerLoadColor : MonoBehaviour {
	
	public MeshRenderer meshRenderer;
	
	public Material material1;
	public Material material2;
	public Material material3;
	public Material material4;
	
	void Start () {
		if (PlayerPrefs.GetInt("Current color theme") <= 0) {
			meshRenderer.material = material1;
		}
		else if (PlayerPrefs.GetInt("Current color theme") == 1) {
			meshRenderer.material = material2;
		}
		else if (PlayerPrefs.GetInt("Current color theme") == 2) {
			meshRenderer.material = material3;
		}
		else if (PlayerPrefs.GetInt("Current color theme") == 3) {
			meshRenderer.material = material4;
		}
	}
}
