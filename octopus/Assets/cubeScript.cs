using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (true)
		{
//			Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

//			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
//			{
				// get the touch position from the screen touch to world point
				Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
				Debug.Log (touchedPos);
				// lerp and set the position of the current object to that of the touch, but smoothly over time.
				transform.position = Vector3.Lerp(transform.position, touchedPos, 1);
				Debug.Log (transform.position);
//			}
		}
	}
}
