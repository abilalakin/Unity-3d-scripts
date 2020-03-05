using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDif : MonoBehaviour {

	public float rotationSpeed;

	float lockPos = 0;

/*	private void OnMouseDrag()
	{
		if (!Input.GetKey(KeyCode.LeftControl)) {
		
		float Y = Input.GetAxis("Mouse Y") * rotationSpeed;

		float X = Input.GetAxis("Mouse X") * rotationSpeed;

		transform.Rotate(Vector3.right, Y);
		transform.Rotate(Vector3.up, -X);
		}

	} */

	void Update() {

	//	        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,lockPos);
		Vector3 rot = transform.eulerAngles;
 		transform.rotation = Quaternion.Euler(rot.x, rot.y + Time.deltaTime * rotationSpeed, rot.z);
	}

}
