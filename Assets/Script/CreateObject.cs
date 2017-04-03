using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

	public Transform Spawnpoint;
	public Transform SpawnDrum;
	public GameObject Egbomen;
	public GameObject Drum;
	public float Delay;
	private float spawned;
	public bool drumTriggered = false;



	void Start () {
		spawned = 1;

	}

	void Update()
	{
		if (drumTriggered) 
		
		{
			Spawndrum ();
		}
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			drumTriggered = true;
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

			Instantiate (Egbomen, Spawnpoint.position, Spawnpoint.rotation);

		}
	}

	public void Spawndrum()
	    {

			Instantiate (Drum, SpawnDrum.position, SpawnDrum.rotation);
		drumTriggered = false;
		}			
	}
	
