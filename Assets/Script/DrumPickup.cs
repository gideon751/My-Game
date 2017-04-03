using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DrumPickup : MonoBehaviour {

	public GameObject gate01;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			gate01.GetComponent<BoxCollider> ().enabled = true;
			gameObject.GetComponent<MeshRenderer>().enabled = false;
			gameObject.GetComponent<AudioSource>().enabled = false;
		}
	}
}


