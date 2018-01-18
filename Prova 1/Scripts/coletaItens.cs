using UnityEngine;
using System.Collections;

public class coletaItens : MonoBehaviour {

	public Collider nextItem;

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){

			Destroy(this.gameObject);
			if(nextItem){
				nextItem.collider.enabled = true;
			}
			if(this.gameObject.name == "Cylinder"){
				esteira.puzzleOK = true;
			}
		}
	}
}
