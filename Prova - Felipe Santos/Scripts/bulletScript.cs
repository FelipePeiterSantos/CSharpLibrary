using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
	
	static int counter = 0;

	void OnCollisionEnter(Collision coll){

		if(coll.gameObject.name == "Red Pillar" && counter == 0){
			Destroy(coll.gameObject);
			counter++;
			GameObject.FindGameObjectWithTag("secDoor").transform.position = new Vector3(0.89f,1.58f,15.62f);
		}
		else if(coll.gameObject.name == "Green Pillar" && counter == 1){
			Destroy(coll.gameObject);
			counter++;
		}
		else if(coll.gameObject.name == "Blue Pillar" && counter == 2){
			Destroy(coll.gameObject);
			counter++;
		}
		else if(coll.gameObject.name == "Yellow Pillar" && counter == 3){
			Destroy(coll.gameObject);
			counter++;
			GameObject.FindGameObjectWithTag("light").SetActive(false);
			GameObject.FindGameObjectWithTag("fall").SendMessage("StartFall");

		}

		Destroy (this.gameObject);
		Debug.Log ("Destroy");
	}
}
