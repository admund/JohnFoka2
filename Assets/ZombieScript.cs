using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {
	private float zombieSpeed = 3f;
	
	public Transform playerPos;
	
	// Use this for initialization
	void Start () {
		float x = Random.Range(-50, 50);
		float y = Random.Range(5, 50);
		transform.position = new Vector3(x, y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveDirection = playerPos.position - transform.position;
		moveDirection.z = 0f;
		moveDirection.Normalize();
		
		CharacterController controller = (CharacterController)GetComponent("CharacterController");
		controller.Move(moveDirection * Time.deltaTime * zombieSpeed);
	}
}
