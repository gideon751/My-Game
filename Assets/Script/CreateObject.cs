using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour {

	public Transform Spawnpoint;
	public Transform SpawnDurm;
	public GameObject Egbomen;
	public GameObject Drum;
	public float Delay;
	private float spawned;



	void Start () {
		spawned = 1;

	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			SpawnEnemy();
			Invoke ("SpawnEnemy", 0.8f);
			Invoke ("SpawnEnemy", 1.6f);
			Invoke ("SpawnEnemy", 2.4f);
			Invoke ("SpawnEnemy", 3.2f);
				

		}

	}

		public void SpawnEnemy() {

		spawned += 1;

		if (spawned <= 5) {

			Instantiate (Egbomen, Spawnpoint.position, Spawnpoint.rotation);

		}
	}

	public void Spawndrum(){
		spawned += 1;

		if (spawned <= 2) {

			Instantiate (Drum, Spawnpoint.position, Spawnpoint.rotation);
		}			
	}
}

