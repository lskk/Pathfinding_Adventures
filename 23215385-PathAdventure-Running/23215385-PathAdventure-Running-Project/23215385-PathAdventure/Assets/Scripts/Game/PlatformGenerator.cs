using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {
	
	public float timeToGenerateObject;
	public GameObject objectToGenerate;

	void Start () {
		InvokeRepeating("Generate", 0f, timeToGenerateObject);
	}

	void Generate () {
		Instantiate(objectToGenerate);
	}
}
