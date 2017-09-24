using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCylinderController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		float horizontal_movement = Input.GetAxis("Horizontal");
		float vertical_movement = Input.GetAxis("Vertical");

		transform.position += new Vector3 (horizontal_movement, 0, vertical_movement);
	}
}
