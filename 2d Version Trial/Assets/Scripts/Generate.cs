using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject beams;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 2f);
	}
	
	void CreateObstacle()
	{
		Instantiate(beams);
	}
}
