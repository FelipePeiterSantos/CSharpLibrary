using UnityEngine;
using System.Collections;

public class esteira : MonoBehaviour {

	public GameObject esteiraPrefab;
	public Transform secondPosition;
	public GameObject prensa;
	public static bool puzzleOK = false; 
	static int spawn = 0;

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller" && puzzleOK){
			++spawn;
			if(spawn < 3){
				Instantiate(esteiraPrefab,secondPosition.position,Quaternion.identity);
			}
		}
		if(spawn == 3){
			prensa.SendMessage("AtivaPrensa");
		}
	}
}
