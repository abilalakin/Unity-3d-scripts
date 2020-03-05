using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour {

	public int minZoom3d, maxZoom3d;
	public int zoomSpeed3d;


	void Start() {

	}
	// Update is called once per frame
	void Update () {
		
			if (Input.GetAxis("Mouse ScrollWheel") > 0)
			{
				//ZoomIn
				Camera.main.fieldOfView -= zoomSpeed3d * Time.deltaTime;
			}

			if (Input.GetAxis("Mouse ScrollWheel") < 0)
			{
				//ZoomOut
				Camera.main.fieldOfView += zoomSpeed3d * Time.deltaTime;
			}

			Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView,minZoom3d,maxZoom3d); // Restrict min and max zoom

		}
}
