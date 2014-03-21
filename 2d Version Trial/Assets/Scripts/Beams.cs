using UnityEngine;
using System.Collections;

public class Beams : MonoBehaviour {

	public Vector2 velocity = new Vector2(4, 0);

	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;

		float randomRange = Random.Range (-3.5f, 3.5f);
		float random = Random.value;

		transform.position = new Vector3(transform.position.x, transform.position.y - randomRange * random, transform.position.z);
	}
}
