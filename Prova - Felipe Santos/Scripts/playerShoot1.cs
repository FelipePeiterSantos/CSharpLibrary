using UnityEngine;
using System.Collections;

public class playerShoot1 : MonoBehaviour {

	public static bool isEnableToShoot = false;
	public GameObject bulletPrefab;

	void Update () {
		if(Input.GetMouseButtonDown(0) && isEnableToShoot){
			GameObject aux = Instantiate(bulletPrefab,Camera.main.transform.position,Quaternion.identity) as GameObject;
			Physics.IgnoreCollision(this.collider,aux.collider);
			aux.rigidbody.AddForce(Camera.main.transform.forward * 1000);
		}

	}
	void OnGUI(){
		if(isEnableToShoot){
			GUI.Label (new Rect(Screen.width/2-10,Screen.height/2-10,20,20),"+");
		}
	}
}
