using UnityEngine;
using System.Collections;

public class openFirstDoor : MonoBehaviour {

	public Transform fatherDoor;
	bool openDoor = false;

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller" && switchDoor.objCount >= 3){
			openDoor = true;
		}
	}

	void OnTriggerExit(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			openDoor = false;
		}
	}

	void Update(){
		if(openDoor && fatherDoor.position.x < 5.4f){
			fatherDoor.position = fatherDoor.position + (Vector3.right * Time.deltaTime);
		}
		else if(!openDoor && fatherDoor.position.x > 0.8f){
			fatherDoor.position = fatherDoor.position - (Vector3.right * Time.deltaTime);
		}
	}
}
