using UnityEngine;
using System.Collections;

public class PlayerBlockController : MonoBehaviour {

	public GameObject player;

	void Update () {
		//Set to player coordinates
		gameObject.transform.position = new Vector3(player.transform.position.x, gameObject.transform.position.y, player.transform.position.z);
	}
}
