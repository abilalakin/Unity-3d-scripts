using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickZoomButton : MonoBehaviour {

	public float baseFOV;
	public bool isZoom = false;
	// Use this for initialization
	void Start () {
		baseFOV = Camera.main.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
	//	ZoomInOut();
		
	}


	public void ZoomInOut () {

		if (isZoom) {

		/*	Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
        	RaycastHit hit1;

			if (Physics.Raycast(ray1,out hit1,Mathf.Infinity)) {

					Camera.main.fieldOfView = baseFOV;

					isZoom = false;
			} */

			Camera.main.fieldOfView = baseFOV;

			isZoom = false;

		}

		else {
 		// get ray from camera in to scene at the mouse position
     /*   Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
*/
        // hardcoded "zoom" distance.
        float zoomDist = 40.0f;

        // Raycast from camera to mouse cursor, if object hit, zoom.
     /*   if (Physics.Raycast(ray,out hit,Mathf.Infinity)){       
         
			Camera.main.fieldOfView = zoomDist;

			isZoom = true;

		} */

		Camera.main.fieldOfView = zoomDist;

		isZoom = true;
	}
}

}
