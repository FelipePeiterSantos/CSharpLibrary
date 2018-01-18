using UnityEngine;
using System.Collections;

public class ammoPack : MonoBehaviour {

	public int ammoQtd = 0;

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			playerShoot.clip += ammoQtd;
			Destroy(this.gameObject);
		}
	}
}
