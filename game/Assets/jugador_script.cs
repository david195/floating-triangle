using UnityEngine;
using System.Collections;
using ChartboostSDK;

public class jugador_script : MonoBehaviour {
	public enemigo_script enem1;
	public enemigo_script enem2;
	public jugador_script jug;
	public txt_script tx;
	public GUIText go;
	public GUITexture face;
	public facebook fc;
	static bool stop;

	// Use this for initialization
	void Start () {
		stop = false;
	}

	// Update is called once per frame
	void Update () {
		if (stop)
				if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
						if (face.guiTexture.HitTest(Input.GetTouch (0).position)) {
						fc.share("https://play.google.com/store/apps/details?id=com.drgames.floatingtriangle","https://lh3.ggpht.com/p6pJrXlR3iMODa6a6LGRaAuyevGzkHliVI1EIOiUgEhc4B9wsurj9z8yc4OYK0HYJA=w300","Floating Triangle","New Score: " + tx.setcount(),"Congratulations!!!","http://www.facebook.com");
						} else
								cerrar ();
				}
				else
						return;
		float x = Input.acceleration.x/3;
		if ((this.transform.position.x + x) > (2.2))
			this.transform.position = new Vector3(2.2f,-4.48f,0);
		else
			this.transform.Translate (x, 0, 0);
		if ((this.transform.position.x + x) < (-2.2))
			this.transform.position = new Vector3(-2.2f,-4.48f,0);
		else
			this.transform.Translate (x, 0, 0);
		Screen.sleepTimeout =0;
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "enemigo") {
			Destroy(this.gameObject.renderer);
			Chartboost.showInterstitial(CBLocation.Default);
			face.transform.position = new Vector3(0.48f,0.2f,0f);
			enem1.parar();
			enem2.parar();
			stop = true;
			guardar();
			go.transform.position = new Vector3(0.3f,0.5f,0f);
		}	
	}
	void guardar(){
		int lr = PlayerPrefs.GetInt ("record");
		if(tx.setcount() > lr)
			PlayerPrefs.SetInt("record",tx.setcount());
	}

	void cerrar(){
		Application.LoadLevel (0);
	}
}