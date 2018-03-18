using UnityEngine;
using System.Collections;

public class play_script : MonoBehaviour {
	//public GUIText tx;
	public GUITexture play;
	// Use this for initialization
	void Start(){
		/*int i = 0;
		if(PlayerPrefs.GetInt ("record") != null)
			i = PlayerPrefs.GetInt ("record");
		tx.guiText.text = i.ToString ();*/
	}
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began && play.guiTexture.HitTest (Input.GetTouch (0).position))
			Application.LoadLevel (1);
	}
}
