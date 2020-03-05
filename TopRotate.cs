using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopRotate : MonoBehaviour {

	public float speed = 5.0f;

	IEnumerator RotateTop( Vector3 axis, float angle, float duration = 1.0f)
   {
     Quaternion from = transform.rotation;
     
	 Quaternion toX = transform.rotation;
	 
     // to *= Quaternion.Euler( axis * angle );
	 toX = Quaternion.Euler(-90,transform.rotation.y,transform.rotation.z); 
    
	 float elapsed = 0.0f;
     while( elapsed < duration )
     {
       transform.rotation = Quaternion.Slerp(from, toX, elapsed / duration );
       elapsed += Time.deltaTime;
       yield return null;
     }
     transform.rotation = toX;
   }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void RotateAroundX() {
	//	transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(90,transform.rotation.y,transform.rotation.z),speed * Time.deltaTime);

		StartCoroutine(RotateTop(Vector3.left, 90, 0.7f));
	}


}
