using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayText : MonoBehaviour {

	public string myString;
	public Text myText;

	public float fadeTime;

	public bool isDisplay;

	void Start () {

		myText = GameObject.Find("Text").GetComponent<Text>();
		myText.color = Color.clear;


	}

	void Update() {

		FadeText();
	}

	void OnMouseOver() {

		isDisplay = true;
	}

	void OnMouseExit() {

		isDisplay = false;
	}

	void FadeText() {

		if (isDisplay) {

			myText.text = myString;
			myText.color = Color.Lerp(myText.color,Color.white,fadeTime*Time.deltaTime);
		}

		else {

			myText.color = Color.Lerp(myText.color,Color.clear,fadeTime*Time.deltaTime);
		}
	}
}
