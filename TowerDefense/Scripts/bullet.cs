using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public Transform target;
	
	void Update () {

		if(target){
			transform.position = Vector3.MoveTowards (transform.position,target.position,0.05f);
		}
		else {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag == "car" && this.gameObject.name == "stun"){
			coll.SendMessage("Stunned");
			Destroy(this.gameObject);
		}
		else if(coll.gameObject.tag == "car" && this.gameObject.name == "damage"){
			coll.SendMessage("Damaged");
			Destroy(this.gameObject);
		}
		else if(coll.gameObject.tag == "tower" && this.gameObject.name == "damageCar"){
			coll.SendMessage("Damaged");
			Destroy(this.gameObject);
		}
	}
}
