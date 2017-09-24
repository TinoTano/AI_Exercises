using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractedCylinder : MonoBehaviour {

	public Transform player;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * speed);
	}
}
