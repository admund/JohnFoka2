using UnityEngine;
using System.Collections;

public class AttackPlayerScript : MonoBehaviour {
	private float shotDelay = 0.3f;
	private float lastShotTime = 0;
	
	public Transform fireBall;
	public Transform fireBall2;
	
	public GameObject zombie;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0)) {
			if(Time.time - lastShotTime > shotDelay) {
				Instantiate(fireBall, transform.position, Quaternion.identity);
				lastShotTime = Time.time;
			}
		}
		
		if(Input.GetMouseButton(1)) {
			Instantiate(fireBall2, transform.position, Quaternion.identity);
		}
		
		if(Input.GetKeyDown(KeyCode.Z))
			GameObject.Instantiate(zombie);
	}
}
