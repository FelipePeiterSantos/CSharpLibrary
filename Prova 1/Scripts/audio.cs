using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller" && esteira.puzzleOK){
			GetComponent<AudioSource>().Play();
		}
	}
}
