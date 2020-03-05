using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableScript : MonoBehaviour {

	private Rotate myScript;
	// Use this for initialization
	void Start () {
		myScript = GetComponent<Rotate> ();

		myScript.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
