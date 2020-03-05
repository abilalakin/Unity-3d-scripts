using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableScroll : MonoBehaviour {

	RectTransform rt,temp;
	bool isHide = true;

	Vector3 firstScale;

	// Use this for initialization
	void Start () {
		temp = GetComponent<RectTransform>();
		firstScale = temp.localScale;
		hideIt();
		
	}
	
	// Update is called once per frame
	void Update () {
	//	showIt();
	}

	public void hideIt() {
		rt = GetComponent<RectTransform>();
		rt.localScale = new Vector3(0,0,0);

	}

	public void showIt() {
	//	rt = GetComponent<RectTransform>();	

		rt.localScale = new Vector3(1,1,1);


	}

	public void hideShow() {

		if (isHide) {
			rt = GetComponent<RectTransform>();	
		//	rt.localScale = new Vector3(0.5f,0.5f,0.5f);
			rt.localScale = firstScale;
			isHide = false;
		}

		else {
			rt = GetComponent<RectTransform>();
			rt.localScale = new Vector3(0,0,0);
			isHide = true;
		}
	}
}
