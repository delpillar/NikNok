using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 jumpSpeed = new Vector2(0,30);

	Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(new Vector2(0,jumpSpeed.y * 10));
			anim.SetTrigger("Jump");
				}

		//if (Input.GetTouch (0).phase == TouchPhase.Began) {
		//	rigidbody2D.velocity = Vector2.zero;
		//	rigidbody2D.AddForce(jumpSpeed);
		//}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}

	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

}
