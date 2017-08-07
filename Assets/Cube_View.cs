using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_View : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void Update () {
		Vector3 vec = transform.position;
		if (vec.x < 0 || vec.x > 5) {
			speed *= -1;
		}
		transform.position += new Vector3 (speed, 0, 0);
	}
}
