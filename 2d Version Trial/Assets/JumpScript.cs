using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			this.rigidbody2D.AddForce(new Vector2(0, 300.0f));
				}
	}

}
