using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour {

	public Collider coll;
	public Rigidbody otherGateRigidBody;

	// Use this for initialization
	void Start () {
		coll = GetComponent<Collider> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			otherGateRigidBody.useGravity = true;
			otherGateRigidBody.isKinematic = false;
		}
		/*if (fence_open.attachedRigidbody)
			fence_open.attachedRigidbody.useGravity = true;
		Debug.Log ("Open");
		*/
	}


}
