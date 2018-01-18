using UnityEngine;
using System.Collections;

public class torreLife : MonoBehaviour {

	int life = 50;

	void Update () {
		if(life <= 0){
			Destroy(this.gameObject);
		}
	}

	void Damaged(){
		--life;
	}
}
