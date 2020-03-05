using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    float lockPos = 0;

    float object_rotX,object_rotY;
    void OnMouseDrag() {
        
        if (!Input.GetKey(KeyCode.LeftControl)) { // To move the object with left control and left mouse 
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(-pitch, -yaw, 0f);
    
   /* object_rotX = Input.GetAxis("Mouse X") * speedH * Time.deltaTime;
    object_rotY = Input.GetAxis("Mouse Y") * speedV * Time.deltaTime;
    transform.RotateAround(transform.position, new Vector3(object_rotY, -object_rotX, 0), 400 * Time.deltaTime);
       */
        }

    
    }

    void Update() {

     //   transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,lockPos);
    }
}
