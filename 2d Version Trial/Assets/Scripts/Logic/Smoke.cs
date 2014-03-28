using UnityEngine;
using System.Collections;

public class Smoke : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);

	// Use this for initialization
	void Start()
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(player.transform.position.x - 1, player.transform.position.y, 2);

	}

	void Update()
	{
		if (rigidbody2D.transform.position.x <= -4.7) {
			Destroy(this.gameObject);
				}

	}

}
