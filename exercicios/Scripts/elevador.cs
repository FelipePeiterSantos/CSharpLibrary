using UnityEngine;
using System.Collections;

public class elevador : MonoBehaviour {

	float cooldown = 2;
	bool active = false;

	void Update(){
		if(active){
			cooldown -= Time.deltaTime;
			if(cooldown < 0){
				GetComponent<Animator> ().speed = 1;
				active = false;
			}
		}
	}

	void OnTriggerEnter(Collider coll){
		active = true;
		cooldown = 2;
	}

	void OnTriggerExit(Collider coll){
		active = false;
		cooldown = 2;
	}

	public void activeElevator(){
		GetComponent<Animator> ().speed = 0;
	}
}
