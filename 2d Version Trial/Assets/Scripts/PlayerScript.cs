using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {



	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(new Vector2(0, 300));
				}
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
