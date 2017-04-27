using UnityEngine;
using System.Collections;

public class Destoryscript : MonoBehaviour
{

	public float destroyTime = 3.0f;
	public GameObject[] enemies;

	// Use this for initialization
	void Start () 
	{
		//Destroy (gameObject, destroyTime);
	}

	void Update()
	{
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
			
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			/*
			foreach (GameObject enemy in enemies) 
			{
				GameObject.Destroy (enemy);
			}
			*/
			Destroy (gameObject);

		}

	}
}
