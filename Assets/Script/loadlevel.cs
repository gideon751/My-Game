using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour {

	public string levelName;

	void Start(){
		//Cursor.visible = true;

	
	}

	void Update (){
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		//Cursor.lockState = CursorLockMode.Confined;
	}
	//Update is called once per frame
	public void LoadLevelNow (string x) {
		SceneManager.LoadScene (x);
	}
}