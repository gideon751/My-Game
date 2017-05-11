using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PauseMenu : MonoBehaviour {

	public GameObject PauseMainMenu;
	public FirstPersonController firstPersonControllerScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P))
		{
			if (Time.timeScale == 1) {
				PauseMainMenu.SetActive (true);
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				firstPersonControllerScript.enabled = false;

				Time.timeScale = 0;
			} else {
				PauseMainMenu.SetActive (false);
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Confined;
				firstPersonControllerScript.enabled = true;

				Time.timeScale = 1;
			}
	}
}
}
