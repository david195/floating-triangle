using UnityEngine;
using System.Collections;

public class txt_script : MonoBehaviour {
	static int count;
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void recargo(){
		count = count + 1;
		this.guiText.text = count.ToString();
	}
	public int setcount(){
		return count;
	}
}
