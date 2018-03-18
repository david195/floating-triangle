using UnityEngine;
using System.Collections;

public class enemigo_script : MonoBehaviour {

	static int giro;
	public txt_script tx;
	public float fin;
	float rx;
	static bool stop;
	public Vector3 gravedad;
	public enemigo_script yo;
	public AudioClip mon;
	// Use this for initialization
	void Start () {
		stop = false;
		giro = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (stop)
						return;
		this.transform.position += gravedad;
		this.transform.Rotate (0, 0,(3+giro));
		if (this.transform.position.y < fin){
			rx = Random.Range((-270),270);
			rx = rx/100;
			tx.recargo();
			this.transform.position = new Vector3(rx,14f,0);
			if(gravedad.x >= (-0.18))
				yo.gravedad -= new Vector3(0,0.004f,0);
			if((Random.Range(1,10) == 3) && (giro <= 25))
				giro++;
			AudioSource.PlayClipAtPoint(mon, transform.position);
		}
	}
	public void parar(){
				stop = true;
		}
}