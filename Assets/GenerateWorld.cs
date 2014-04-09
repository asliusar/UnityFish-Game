using UnityEngine;
using System.Collections;

public class GenerateWorld : MonoBehaviour {
	public Transform block;
	public Transform player;
	private float objectSpawnedTo = 5.0f;
	public static float distanceBetweenObjects = 6.0f;
	private float nextCheck = 0.2f;
	private ArrayList objects  = new ArrayList();

	// Use this for initialization
	void Start () {
		maintenance (0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		float playerX = player.position.x;
		if (playerX > nextCheck) {
			maintenance(playerX);	
		}

	}

	private void maintenance(float playerX) {
		nextCheck = playerX + 90;
		for (int i = objects.Count - 1; i>=0; i--) {
			Transform block = (Transform)objects[i];
			if (block.position.x < (transform.position.x - 10)) {
				Destroy(block.gameObject);
				objects.RemoveAt(i);
			}

		}
		spawnObjects (20);
	}

	private void spawnObjects(int howMany){
		float spawnX = objectSpawnedTo;
		for (int i =0; i<howMany; i++) {
			int rand = Random.Range(0,2);
			Vector3 pos;
			if (rand == 1) {
				pos = new Vector3(spawnX,6,0);
			}else{
				pos = new Vector3(spawnX,-6,0); 
			}
				float firstRandom = Random.Range(2,4);
				Transform blck = (Transform)Instantiate(block,pos,Quaternion.identity);
			if (rand == 1) {
				blck.localScale = new Vector3(1,(8.6f - firstRandom)*2,1);
			}else{
				blck.localScale = new Vector3(1,(firstRandom-8.6f)*2,1);
			}
			objects.Add(blck);
			spawnX = spawnX + distanceBetweenObjects;
			objectSpawnedTo = spawnX;
		}
	}
}
