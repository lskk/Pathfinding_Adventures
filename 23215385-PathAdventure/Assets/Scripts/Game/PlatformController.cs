using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

	public float randomSizeByZFrom;
	public float randomSizeByZTo;
	public float randomSizeByXFrom;
	public float randomSizeByXTo;

	public float platformShiftByX;
	public bool generateStartXCoordinateByPlayerCoordinates;

	public float moveByPoints;
	public float speed;

	public bool startOnTop;
	public float speedForMoveToNormalHeight;

	public bool generateSomethingOnPlatform;
	public GameObject objectForGenerate1;
	public GameObject objectForGenerate2;
	public int ChanseToGenerateSomething;

	void Start () {
		//Set random sizes
		float randomZValue = Random.Range(randomSizeByZFrom, randomSizeByZTo);
		float randomXValue = Random.Range(randomSizeByXFrom, randomSizeByXTo);

		gameObject.transform.localScale = new Vector3(randomXValue, gameObject.transform.localScale.y, randomZValue);

		//Set x position
		if (generateStartXCoordinateByPlayerCoordinates) {
			GameObject player = GameObject.Find("Player");
			
			if (Random.Range(0, 2) == 0) gameObject.transform.position = new Vector3(player.transform.position.x + Random.Range(0.0F, platformShiftByX), gameObject.transform.position.y, gameObject.transform.position.z);
			else gameObject.transform.position = new Vector3(player.transform.position.x - Random.Range(0.0F, platformShiftByX), gameObject.transform.position.y, gameObject.transform.position.z);
		}
		else {
			if (Random.Range(0, 2) == 0) gameObject.transform.position = new Vector3(gameObject.transform.position.x + Random.Range(0.0F, platformShiftByX), gameObject.transform.position.y, gameObject.transform.position.z);
			else gameObject.transform.position = new Vector3(gameObject.transform.position.x - Random.Range(0.0F, platformShiftByX), gameObject.transform.position.y, gameObject.transform.position.z);
		}

		//Set to height
		if (startOnTop) {
			if (Random.Range(0, 2) == 0) gameObject.transform.position = new Vector3(gameObject.transform.position.x, 20, gameObject.transform.position.z);
			else gameObject.transform.position = new Vector3(gameObject.transform.position.x, -20, gameObject.transform.position.z);
		}

		//Add something object to platform
		if (generateSomethingOnPlatform) {
			if (Random.Range(0, 100) <= ChanseToGenerateSomething) {
				int nowGenerateObject = Random.Range(0, 2);

				GameObject childObject;

				if (nowGenerateObject == 0) {
					childObject = Instantiate(objectForGenerate1) as GameObject;
				}
				else {
					childObject = Instantiate(objectForGenerate2) as GameObject;
				}

				childObject.transform.parent = gameObject.transform;
				childObject.transform.localPosition = new Vector3(0, childObject.transform.position.y, 0);
			}
		}
	}

	void Update () {
		//Destroy object
		if (gameObject.transform.position.z <= -7) Destroy(gameObject);
	}

	void FixedUpdate() {
		//Move
		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
		                                             new Vector3(gameObject.transform.position.x, gameObject.transform.position.y ,gameObject.transform.position.z - moveByPoints),
		                                             Time.deltaTime * speed);

		//Move to normal height
		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
		                                             new Vector3(gameObject.transform.position.x, -0.75F, gameObject.transform.position.z),
		                                             Time.deltaTime * speedForMoveToNormalHeight);
	}
}
