using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyFooFoo : MonoBehaviour 
{
	public float destroyTime = 1.0f;
	public GameObject Boost;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
//	void Update () 
//	{
//		Boost = GameObject.FindGameObjectsWithTag ("Boost");
//	}

	void OnTriggerEnter(Collider col) 
	{
		
			Destroy (gameObject);

	}
}
