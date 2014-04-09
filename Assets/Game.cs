using UnityEngine;
using System.Collections;

	public class Game : MonoBehaviour {

	void OnCollisionEnter() {
		restartGame ();
	}
	// Use this for initialization
	void Start () {
		isStartButtonPressed = false;
		Time.timeScale = 0.0f;
	}
	// Update is called once per frame
	void Update () {
		updateScore ();
		if (!isInView()) {
			restartGame();
		}
		if (Input.anyKeyDown) {
			move();
		}

	}
	private bool isInView() {
		Vector3 port = Camera.main.WorldToViewportPoint (transform.position);
		if ((port.x < 1) && (port.x>=0) && (port.y < 1) && (port.y >= 0) && (port.z >= 0)) {
			return true;
		} else {
			return false;
		}
	}

	private bool isStartButtonPressed;
	public GUIText scoreLabel;

	void OnGUI(){
		if (!isStartButtonPressed) {
			GUI.TextField (new Rect (Screen.width / 2 - 65, Screen.height / 2 - 11, 120, 32), "Do something to start");
			if (Input.anyKeyDown) {
			Time.timeScale = 1.0f;
			isStartButtonPressed = true;
			}
		}
	}

	private void move(){
		rigidbody.velocity = new Vector3 (0, 0, 0);
		rigidbody.AddForce(new Vector3(275,400,0),ForceMode.Force);
	}

	private void onTriggerEnter(Collider other)
	{
		restartGame ();
	}

	private void restartGame()
	{
		Time.timeScale = 0.0f;
		isStartButtonPressed = false;
		Application.LoadLevel(Application.loadedLevelName);
	}

	private void updateScore()
	{
		int score = (int)(transform.position.x / GenerateWorld.distanceBetweenObjects);
		//if ((score != (int.Parse(scoreLabel.text))) && (score > 0)) {
			scoreLabel.text = score.ToString();
	//	}
	}
}
