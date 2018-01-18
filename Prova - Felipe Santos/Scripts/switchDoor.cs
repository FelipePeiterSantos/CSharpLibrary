using UnityEngine;
using System.Collections;

public class switchDoor : MonoBehaviour {

	public static int objCount = 0;

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			Destroy(this.gameObject);
			objCount++;
		}
	}
}
