using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public Transform b;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			float x = transform.position.x;
			x+=0.1f;
			b.position = new Vector3(x,0,0);		
		}
	}
}
