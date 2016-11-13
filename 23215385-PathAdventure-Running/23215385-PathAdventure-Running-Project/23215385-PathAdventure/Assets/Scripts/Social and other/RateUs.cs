using UnityEngine;
using System.Collections;

public class RateUs : MonoBehaviour {

	public string linkForRate;

	public void Rate () {
		//Go to webpage for rate app
		Application.OpenURL(linkForRate);
	}
}
