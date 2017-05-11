using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour {

	public Transform Spawnpoint;
	public Transform SpawnDrum;
	public GameObject Egbomen;
	public GameObject Drum;
	//public Text;
	public float Delay;
	private float spawned;
	GameObject player;


	void Start () {
		spawned = 1;

	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			player = col.gameObject;
			Spawndrum ();
			SpawnEnemy();
			Invoke ("SpawnEnemy", 0.8f);
			Invoke ("SpawnEnemy", 1.6f);
			Invoke ("SpawnEnemy", 2.4f);
			Invoke ("SpawnEnemy", 3.2f);
			gameObject.GetComponent<BoxCollider> ().enabled = false;
				

		}

	}

		public void SpawnEnemy() {

		spawned += 1;

		if (spawned <= 5) {

			GameObject egboMan = Instantiate (Egbomen, Spawnpoint.position, Spawnpoint.rotation);
			player.SendMessage ("BeingChased", egboMan.GetComponent<ai> ());
		}
	}

	public void Spawndrum()
	    {
			Instantiate (Drum, SpawnDrum.position, SpawnDrum.rotation);
		}

//	public void Text()
//	{
//
//		Instantiate (Text, SpawnDrum.position, SpawnDrum.rotation);
//		drumTriggered = false;
//	}		
}
	
