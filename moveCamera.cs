using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

	public float horizontalSpeed = 5.0f;

	public float verticalSpeed = 5.0f; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	Vector3 pos = transform.position;
		
		if (Input.GetKey(KeyCode.LeftControl) && Input.GetMouseButton(0)) {
		
		float x = horizontalSpeed * Input.GetAxis("Mouse X");
		float y = verticalSpeed * Input.GetAxis("Mouse Y");
	//	pos.z = 0; // Fix z axis
	//	transform.position = pos;
		transform.Translate(-x,-y,0);

		}
		
	}
}
