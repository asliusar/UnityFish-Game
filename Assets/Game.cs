using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	Vector3 a = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A))
		{
			a = transform.position;
			a.x -=0.1f;
			transform.position = a;
			SpriteRenderer.sprite = "fish";
		}
	if (Input.GetKey (KeyCode.W))
		{
			a = transform.position;
			a.y +=0.1f;
			transform.position = a;
		}
		if (Input.GetKey (KeyCode.D))
		{
			a = transform.position;
			a.x +=0.1f;
			transform.position = a;
		}
		if (Input.GetKey (KeyCode.S))
		{
			a = transform.position;
			a.y -=0.1f;
			transform.position = a;
		}
	}
}
