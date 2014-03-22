using UnityEngine;
using System.Collections;

public class SmokeGenerate : MonoBehaviour {

	public GameObject smoke;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 0f, .15f);
	}
	
	void CreateObstacle()
	{
		Instantiate(smoke);	
	}
}
