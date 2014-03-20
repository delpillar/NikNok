using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	void Update () {


		if (Input.GetMouseButtonDown(0)) {
			float jumpSpeed = 5.0f;
						//transform.Translate (0, 5, 0);
			rigidbody.velocity = new Vector3(0,0,0);
			rigidbody.AddForce(new Vector3(0, 320, 0) * 1.4f, ForceMode.Force);
			//this.rigidbody2D.velocity.y = 5;
		}
		if (Input.GetTouch (0).phase == TouchPhase.Began) {
			this.rigidbody.AddForce(Vector3.up * 100.0f);
		}
	}
}
