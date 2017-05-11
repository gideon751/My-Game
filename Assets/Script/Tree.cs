using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tree : MonoBehaviour {

	public GameObject player;
	public int drums;



	public void Awake() {
		

	}


	public void OnTriggerEnter(Collision collision)
	{
		
		DrumInventory DI = player.GetComponent<DrumInventory> ();

		if (collision.gameObject.tag == "Player") 
		{
			if (DI.DrumCountNumber == 1) {
				SceneManager.LoadScene ("Credit"); // win
			} else {
				SceneManager.LoadScene ("Game Over"); // lose
			}
		}
	}
}
