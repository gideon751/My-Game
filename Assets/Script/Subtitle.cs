using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitle : MonoBehaviour {

	public static GameObject SubtitlePanel;
	public static Text SubtitleText;

	public string Message = "Message not set!";

	// Use this for initialization
	void Start () {

		if (SubtitlePanel == null) 
		{
			SubtitlePanel = GameObject.Find ("SubtitlePanel");
			SubtitleText = SubtitlePanel.GetComponentInChildren<Text> ();

			SubtitlePanel.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter()
	{
		//activate the subtitle panel object
		SubtitlePanel.SetActive (true);
		//set the text inside the panel to the message.
		SubtitleText.text = this.Message;

		hide_panel (10.0f);
	}

	private void hide_panel(float delay)
	{
		StartCoroutine (cr_delayed_hide_panel (delay));
	}

	private IEnumerator cr_delayed_hide_panel(float delay)
	{
		yield return new WaitForSeconds (delay);
		SubtitlePanel.SetActive (false);
	}
}
