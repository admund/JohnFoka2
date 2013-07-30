using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {
	
	public float moveSpeed = 10f;
	public float jumpSpeed = 700f;
	public float fallSpeed = 30f;
	
	private Vector3 moveDirection = Vector3.zero;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = (CharacterController)GetComponent("CharacterController");
		if(controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
			moveDirection *= moveSpeed;
			
			if(Input.GetButton("Jump"))
				moveDirection.y += jumpSpeed * Time.deltaTime;
				
		}
		
		moveDirection.y -= fallSpeed * Time.deltaTime;
		
		controller.Move(moveDirection * Time.deltaTime);
	}
}
