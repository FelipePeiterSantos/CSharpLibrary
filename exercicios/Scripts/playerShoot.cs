using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour {

	public GameObject shoot;
	public static int clip = 10;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			if(clip > 0){
				--clip;
				GameObject shootFire = Instantiate (shoot, Camera.main.transform.position, Camera.main.transform.rotation) as GameObject;
				Physics.IgnoreCollision (shootFire.collider,transform.collider);
				shootFire.rigidbody.AddForce(Camera.main.transform.forward * 5000);
			}
		}
	}
	void OnGUI(){
		GUI.Box (new Rect(0,0,25,30),clip.ToString());
	}
}
