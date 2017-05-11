using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DrumPickup : MonoBehaviour {

	public GameObject gate01;
	public AudioSource loop;
	public AudioSource pickupSFX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			col.GetComponent<DrumInventory> ().SendMessage("PickedUpDrum", gameObject);
			gate01.GetComponent<BoxCollider> ().enabled = true;
			gameObject.GetComponent<MeshRenderer>().enabled = false;
			loop.Stop();
			AudioSource.PlayClipAtPoint(pickupSFX.clip, transform.position);
		}
	}
}


