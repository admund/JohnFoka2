using UnityEngine;
using System.Collections;

public class AttackPlayerScript : MonoBehaviour {
	//public float 
	public Transform fireBall;
	public Transform fireBall2;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0)) {
			Instantiate(fireBall, transform.position, Quaternion.identity);
		}
		
		if(Input.GetMouseButton(1)) {
			Instantiate(fireBall2, transform.position, Quaternion.identity);
		}
	}
}
