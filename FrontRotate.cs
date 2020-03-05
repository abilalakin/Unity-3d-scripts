using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontRotate : MonoBehaviour {

	public float speed = 5.0f;

	IEnumerator RotateBack( Vector3 axis, float angle, float duration = 1.0f)
   {
     Quaternion from = transform.rotation;
     
	 Quaternion toZ = transform.rotation;
	 
     // to *= Quaternion.Euler( axis * angle );
	 toZ = Quaternion.Euler(transform.rotation.x,180,transform.rotation.z);
    
	 float elapsed = 0.0f;
     while( elapsed < duration )
     {
       transform.rotation = Quaternion.Slerp(from, toZ, elapsed / duration );
       elapsed += Time.deltaTime;
       yield return null;
     }
     transform.rotation = toZ;
   }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void RotateAroundZ() {
	//	transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(90,transform.rotation.y,transform.rotation.z),speed * Time.deltaTime);

		StartCoroutine(RotateBack(Vector3.back, 90, 0.7f));
	}


}
