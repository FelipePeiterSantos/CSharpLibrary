using UnityEngine;
using System.Collections;

public class lightSecondRoom : MonoBehaviour {

	public GameObject lightSecondRoomObj;
	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			lightSecondRoomObj.SetActive(true);
			playerShoot1.isEnableToShoot = true;
		}
	}
}
