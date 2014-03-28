using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public GameObject bg1;
	public GameObject bg2;


	// Use this for initialization
	void Start () {

		Instantiate (bg1);
		Instantiate (bg2);
	}
}
