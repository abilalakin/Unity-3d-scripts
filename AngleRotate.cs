using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleRotate : MonoBehaviour {

	public float speed = 5.0f;

	IEnumerator RotateIt( Vector3 axis, float angle, float duration = 1.0f)
   {
     Quaternion from = transform.rotation;
     
	 Quaternion to = transform.rotation;
     to *= Quaternion.Euler( axis * angle );
	
	 float elapsed = 0.0f;
     while( elapsed < duration )
     {
       transform.rotation = Quaternion.Slerp(from, to, elapsed / duration );
       elapsed += Time.deltaTime;
       yield return null;
     }
     transform.rotation = to;
   }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void xRotate() {
	//	transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(90,transform.rotation.y,transform.rotation.z),speed * Time.deltaTime);

		StartCoroutine(RotateIt(Vector3.right, 90, 0.7f));
	}

	public void yRotate() {
		StartCoroutine(RotateIt(Vector3.up, 90,0.7f));
	}

	public void zRotate() {
		StartCoroutine(RotateIt(Vector3.forward, 90, 0.7f));
	}


}
