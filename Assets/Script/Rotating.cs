using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotating : MonoBehaviour {

	private float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		speed = 40 * Time.deltaTime;

		transform.Rotate (Vector3.up * speed);
	}
}
