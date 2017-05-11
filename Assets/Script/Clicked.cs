using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour {


	public void Click () {
		GetComponent<AudioSource> () .Play ();
		
	}
}
