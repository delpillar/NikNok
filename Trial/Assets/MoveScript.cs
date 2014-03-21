using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	void Update () {


		if (Input.GetMouseButtonDown(0)) {
			float jumpSpeed = 5.0f;
						//transform.Translate (0, 5, 0);
			rigidbody.velocity = new Vector2(0,0);
			rigidbody.AddForce(new Vector2(0, 320) * 1.4f, ForceMode.Force);
			//this.rigidbody2D.velocity.y = 5;
		}
		if (Input.GetTouch (0).phase == TouchPhase.Began) {
			rigidbody.velocity = new Vector2(0,0);
			rigidbody.AddForce(new Vector2(0, 320) * 1.4f, ForceMode.Force);
		}
	}
}
