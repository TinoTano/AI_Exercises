using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeCylinder : MonoBehaviour {

	public Transform player;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(transform.position, player.position) < 3)
		{
			Vector3 direction = (transform.position - player.position).normalized;
			Vector3 new_pos = transform.position + (direction*speed);
			transform.position = Vector3.Lerp(transform.position, new_pos, Time.deltaTime * speed);
		}
	}
}
