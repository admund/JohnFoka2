using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour {
	private static int cnt = 0;
	private Vector3 moveDirection;
	
	private float speed = 20f;
		
	// Use this for initialization
	void Start () {
		Vector3 objectScreenPos = Camera.main.WorldToScreenPoint(transform.position);
		moveDirection = Input.mousePosition - objectScreenPos;
		cnt++;
		moveDirection.z = 0f;
		moveDirection.Normalize();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += moveDirection * Time.deltaTime * speed;
		
		if(transform.position.x > 100f || transform.position.y > 100f ||
			transform.position.x < -100f || transform.position.y < -100f) {
			cnt--;
			GameObject.Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag != "Player") {
			Destroy(gameObject);
		}
    }
}
