using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

	public float dampTime = 0.3f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f,0.3f,point.z));
			Vector3 destination = transform.position + delta;
			destination.y = 0;
			transform.position = Vector3.SmoothDamp(transform.position,destination,ref velocity,dampTime);
		}
	}
}
