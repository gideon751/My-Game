using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrumInventory : MonoBehaviour {

	public bool Drum1Collected;
	public GameObject DestroyTarget;
	public int DrumCountNumber;
	public Text Drum1Text;
	public Text DrumCount;
	public GameObject Drum1;
	public GameObject Gate1;
	public GameObject Gate2;
	public GameObject Gate3;
	public GameObject Gate4;
	public GameObject Gate5;

	public AudioSource GateOpenSound;

	List<ai> egboMen = new List<ai> ();



	// Use this for initialization
	void Start () {

		// all drums can be drum1
		Drum1Collected = false;
		Drum1Text.text = "Fined The Drums";
		DrumCountNumber = 0;
	}

	// Update is called once per frame
	void Update () {

		DrumCount.text = "Drums collected : " + DrumCountNumber.ToString ();

	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Drum1")

		{
			DrumCountNumber += 1;
			Drum1Collected = true;
			Drum1Text.text = "Drum Collected";
			DestroyTarget = other.gameObject;
			Destroy (DestroyTarget);

		}

		if (other.gameObject.tag == "TheTree") 
		{
			if (DrumCountNumber == 5) {
				SceneManager.LoadScene ("Credit"); // win
			} else {
				SceneManager.LoadScene ("Game Over"); // lose
			}
		}

		if (other.gameObject.tag == "GateLever1") {
			HitALever (Gate1);
			GateOpenSound.Play ();
		}
		if (other.gameObject.tag == "GateLever2") {
			HitALever (Gate2);
			GateOpenSound.Play ();
		}
		if (other.gameObject.tag == "GateLever3") {
			HitALever (Gate3);
			GateOpenSound.Play ();
		}
		if (other.gameObject.tag == "GateLever4") {
			HitALever (Gate4);
			GateOpenSound.Play ();
		}
	}

	void BeingChased(ai egboMan)
	{
		egboMen.Add (egboMan);
	}

	void HitALever(GameObject gate)
	{
		Drum1Collected = false;
		Drum1Text.text = "Fined The Drums";
		Spin spinScript = gate.GetComponent<Spin> ();

		spinScript.Opened = true;
		foreach (ai enemy in egboMen) {

			Destroy (enemy.gameObject);
		}
	}
}