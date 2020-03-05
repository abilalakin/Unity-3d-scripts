using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnable : MonoBehaviour {

	CanvasGroup canvasGroup;
	// Use this for initialization
	void Start () {
		Hide();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hide() {
		
		canvasGroup = GetComponent<CanvasGroup>();
     		canvasGroup.alpha = 0.3f; //this makes everything transparent
    // canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
 	}

	public void Show() {
		
		canvasGroup = GetComponent<CanvasGroup>();
     		canvasGroup.alpha = 1f;
     		canvasGroup.blocksRaycasts = true;
 	}

}
