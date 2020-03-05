using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickZoom : MonoBehaviour {

	
	public float baseFOV;
	public bool isZoom = false;
	// Use this for initialization
	void Start () {
		baseFOV = Camera.main.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0) && isZoom) {

			

			Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
        	RaycastHit hit1;

			if (Physics.Raycast(ray1,out hit1,Mathf.Infinity)) {

					Camera.main.fieldOfView = baseFOV;

					isZoom = false;
			}

			
		}
		
		else if (Input.GetMouseButtonDown(0)){
        // get ray from camera in to scene at the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // hardcoded "zoom" distance.
        float zoomDist = 15.0f;

        // Raycast from camera to mouse cursor, if object hit, zoom.
        if (Physics.Raycast(ray,out hit,Mathf.Infinity)){       
            // Create a second ray from the hit object back out, zoom the camera along this ray.
         //   Ray r = new Ray(hit.point,hit.normal);
          //  Camera.main.transform.position = r.GetPoint(zoomDist);

			Camera.main.fieldOfView = zoomDist;

			isZoom = true;
		
		}
    }

		
	}
}
