using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {
	public Transform player;
	public float cameraDistance;
	public float cameraHigh;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.position + new Vector3(0f, cameraHigh, cameraDistance);
	}
}
