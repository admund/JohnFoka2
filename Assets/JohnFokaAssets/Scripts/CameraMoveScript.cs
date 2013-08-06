using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {
	public Transform player;
	public float cameraDistance;
	public float cameraHigh;
	
	private float cameraLimit = 25f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.position + new Vector3(0f, cameraHigh, cameraDistance);
		correctPossition();
	}
	
	private void correctPossition() {
		float y = transform.position.y;
		float z = transform.position.z;
		
		if(transform.position.x > cameraLimit)
			transform.position = new Vector3(cameraLimit, y, z);
		
		if(transform.position.x < -cameraLimit)
			transform.position = new Vector3(-cameraLimit, y, z);
	}
}
