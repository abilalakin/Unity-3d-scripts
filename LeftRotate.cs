using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotate : MonoBehaviour {

	public float speed = 5.0f;

	IEnumerator RotateYAxis( Vector3 axis, float angle, float duration = 1.0f)
   {
     Quaternion from = transform.rotation;
     
	 Quaternion toY = transform.rotation;
	 
     // to *= Quaternion.Euler( axis * angle );
	 toY = Quaternion.Euler(transform.rotation.x,90,transform.rotation.z);
    
	 float elapsed = 0.0f;
     while( elapsed < duration )
     {
       transform.rotation = Quaternion.Slerp(from, toY, elapsed / duration );
       elapsed += Time.deltaTime;
       yield return null;
     }
     transform.rotation = toY;
   }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void RotateAroundY() {
	//	transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(90,transform.rotation.y,transform.rotation.z),speed * Time.deltaTime);

		StartCoroutine(RotateYAxis(Vector3.up, 90, 0.7f));
	}


}
