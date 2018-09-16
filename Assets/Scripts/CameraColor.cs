using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColor : MonoBehaviour {
	
	private int counter;
	Camera cam;


	void Start () {
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		cam.backgroundColor = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
		{
			counter += 1;
		}

		if (counter == 1)
		{
			cam.backgroundColor = Color.yellow;
		}
		if (counter == 2)
		{
			cam.backgroundColor = Color.green;
		}
		if (counter == 3)
		{
			cam.backgroundColor = Color.blue;
		}
		if (counter == 4)
		{
			cam.backgroundColor = Color.red;
		}
		if (counter == 5)
		{
			counter = 1;
		}
	}
}
