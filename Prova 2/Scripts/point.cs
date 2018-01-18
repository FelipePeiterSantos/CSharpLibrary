using UnityEngine;
using System.Collections;

public class point : MonoBehaviour {
	
	int bluePoint = 0;
	int redPoint = 0;
	int greenpoint = 0;
	static int isOver;

	void Start(){
		isOver = 0;
	}

	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.tag == "verdeInst" && this.gameObject.name == "esfera"){
			coll.gameObject.tag = "used";
			greenpoint++;
			if(greenpoint >= 5){
				Destroy(this.gameObject);
				Destroy(GameObject.FindGameObjectWithTag("HUDverde"));
				isOver++;
				DestroyAll();
			}
		}
		if(coll.gameObject.tag == "azulInst" && this.gameObject.name == "capsula"){
			coll.gameObject.tag = "used";
			bluePoint++;
			if(bluePoint >= 5){
				Destroy(this.gameObject);
				Destroy(GameObject.FindGameObjectWithTag("HUDazul"));
				isOver++;
				DestroyAll();
			}
		}
		if(coll.gameObject.tag == "vermelhoInst" && this.gameObject.name == "cubo"){
			coll.gameObject.tag = "used";
			redPoint++;
			if(redPoint >= 5){
				Destroy(this.gameObject);
				Destroy(GameObject.FindGameObjectWithTag("HUDvermelho"));
				isOver++;
				DestroyAll();
			}
		}
	}
	public void DestroyAll(){
		GameObject[] aux = GameObject.FindGameObjectsWithTag("verdeInst");
		foreach (GameObject item in aux) {
			Destroy(item);
		}
		aux = GameObject.FindGameObjectsWithTag("azulInst");
		foreach (GameObject item in aux) {
			Destroy(item);
		}
		aux = GameObject.FindGameObjectsWithTag("vermelhoInst");
		foreach (GameObject item in aux) {
			Destroy(item);
		}
		aux = GameObject.FindGameObjectsWithTag("used");
		foreach (GameObject item in aux) {
			Destroy(item);
		}

		if(isOver >= 3){
			Debug.Log("ALL");
			Destroy(GameObject.FindGameObjectWithTag ("criador"));
			Application.LoadLevel(0);
		}
	}
}
