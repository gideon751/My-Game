using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitle : MonoBehaviour {

	public GameObject SubtitleText;
	public GameObject SubtitlePanel;
	public AudioSource voiceSFX;
	public string Message = "Message not set!";
	bool isEntered;
	bool isOn;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (isEntered && Input.GetKeyDown (KeyCode.T)) 
		{
			SubtitleText.SetActive(!isOn);
			SubtitlePanel.SetActive(!isOn);
			isOn = !isOn;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			//activate the subtitle panel object
			//SubtitlePanel.SetActive (true);
			//set the text inside the panel to the message.
			SubtitleText.SetActive (true);
			SubtitlePanel.SetActive (true);
			isOn = true;
			isEntered = true;
			//AudioSource.PlayClipAtPoint(voiceSFX.clip, transform.position);
			voiceSFX.Play();
		}
		//hide_panel (10.0f);
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			//SubtitlePanel.SetActive (false);
			SubtitleText.SetActive (false);
			SubtitlePanel.SetActive (false);
			voiceSFX.Stop ();
			isOn = false;
			isEntered = false;
		}
	}


	//private void hide_panel(float delay)
	//{
	//	StartCoroutine (cr_delayed_hide_panel (delay));
	//}

	//private IEnumerator cr_delayed_hide_panel(float delay)
	//{
	//	yield return new WaitForSeconds (delay);
	//	SubtitlePanel.SetActive (false);
	//}
}
