using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public GameObject other;
	bool teleportActive = false;

	void OnTriggerStay (Collider coll) {
		if(coll.gameObject.name == "First Person Controller"){
			teleportActive = true;
		}
		if(Input.GetKeyDown(KeyCode.E)){
			coll.transform.position = other.transform.position;
		}
	}	

	void OnTriggerExit(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			teleportActive = false;
		}
	}

	void OnGUI(){
		if(teleportActive){
			GUI.Box (new Rect(Screen.width/2,Screen.height/2,200,22),"Aperte E para teleportar");
		}
	}
}
