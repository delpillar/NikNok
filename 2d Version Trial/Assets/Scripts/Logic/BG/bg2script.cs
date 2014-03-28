using UnityEngine;
using System.Collections;

public class bg2script : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);

	void Start () {
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(10, 0, 3);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = rigidbody2D.transform.position;
		
		if (temp.x <= -10) {
			temp.x = 10;
		}
		
		rigidbody2D.transform.position = temp;
	}
}
