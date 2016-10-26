using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
	public Rigidbody rigidBody;
	public GameObject changeSceneObject;

	bool movePlayer;
	bool movePlayerToLeft;
	public float movePlayerByPoints;
	public float speedMovePlayer;

	public Text labelCoin;
	public Text labelScore;
	int score;
	public float timeToChangeScore;
	bool gameIsPlay;

	public float jumpPower;

	void Start () {
		score = 0;
		gameIsPlay = true;
		InvokeRepeating("ChangeScore", 0f, timeToChangeScore);
	}

	void Update () {
		if (gameIsPlay) {
			if(Input.GetButton("Fire1")) {
				if (Input.mousePosition.x < Screen.width / 3) {
					movePlayer = true;
					movePlayerToLeft = true;
				}
				else if (Input.mousePosition.x < Screen.width - (Screen.width / 3)) {
					Jump();
				}
				else {
					movePlayer = true;
					movePlayerToLeft = false;
				}
			}
			else {
				movePlayer = false;
			}
		}
		
		//Find end game
		if (gameObject.transform.position.y <= -10) {
			gameIsPlay = false;
			
			//Save score
			PlayerPrefs.SetInt("CurrentScore", score);
			if (score > PlayerPrefs.GetInt("HighScore")) {
				PlayerPrefs.SetInt("HighScore", score);
				PlayerPrefs.SetInt("New best score", 1);
			}
			else {
				PlayerPrefs.SetInt("New best score", 0);
			}
			
			//Change scene
			if (gameObject.transform.position.y <= -35) {
				changeSceneObject.GetComponent<ChangeScenes>().ChangeSceneToEnd();
			}
		}
	}
	
	void FixedUpdate () {
		if (gameIsPlay) {
			//Moving player
			if (movePlayer) {
				if (movePlayerToLeft) {
					gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
					                                             new Vector3(gameObject.transform.position.x - movePlayerByPoints, gameObject.transform.position.y, gameObject.transform.position.z),
					                                             Time.deltaTime * speedMovePlayer);
				}
				else {
					gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
					                                             new Vector3(gameObject.transform.position.x + movePlayerByPoints, gameObject.transform.position.y, gameObject.transform.position.z),
					                                             Time.deltaTime * speedMovePlayer);
				}
			}
		}
	}

	void ChangeScore () {
		if (gameIsPlay) {
			score++;
			labelScore.text = score.ToString();
		}
	}

	void Jump() {
		if (gameIsPlay) {
			if (!(gameObject.transform.position.y >= 0.5F)) {
				if (!(gameObject.transform.position.y <= -0.5F)) {
					rigidBody.AddForce(Vector3.up * jumpPower);
				}
			}
		}
	}
	
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Coin")  {
			Destroy(col.gameObject);

			//Change coin
			PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
			labelCoin.text = PlayerPrefs.GetInt("Coin").ToString();
		}
	}
}
