using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public float speed;
	
	
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		velocity += gravity * Time.deltaTime;
		
		float x = Input.GetAxis("X");
		float y = Input.GetAxis("Y");
		
		x = x * Time.deltaTime * speed;
		y = y * Time.deltaTime * speed;
		Vector3 tmp = new Vector3 (x, y, 0);
		velocity += tmp * Time.deltaTime;
		transform.Translate (velocity );//listen more
	}
	
	void FixedUpdate(){
	}
}