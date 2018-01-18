using UnityEngine;
using System.Collections;

public class alavanca : MonoBehaviour {

	public bool actived = false;

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			actived = true;
			Destroy(this.gameObject);
		}
	}
}

