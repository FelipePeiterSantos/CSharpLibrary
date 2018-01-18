using UnityEngine;
using System.Collections;

public class switchLight : MonoBehaviour {

	public GameObject lightObj;
	bool switchButton = true;

	void OnTriggerStay(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			if(Input.GetKeyDown(KeyCode.E)){
				lightObj.SetActive(switchButton);
				switchButton = !switchButton;
				audio.Play();
			}
		}
	}
}
