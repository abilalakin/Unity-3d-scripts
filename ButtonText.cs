using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonText : MonoBehaviour {

	public Text display;

	public string textToDisplay;
	// Use this for initialization
	void Start () {
		display.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisplayText() {

		display.text = "" + textToDisplay;
	}
}
