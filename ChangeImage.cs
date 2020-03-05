using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ChangeImage : MonoBehaviour {

	public Button myButton;
	public Sprite plus;

	public Sprite minus;

	bool isPlus = true;
	// Use this for initialization
	void Start () {
		myButton = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeButton() {
		if (isPlus) {

			myButton.GetComponent<Image>().sprite = minus;
			isPlus = false;
		}

		else {

			myButton.GetComponent<Image>().sprite = plus;
			isPlus = true;
		}

	}
}
