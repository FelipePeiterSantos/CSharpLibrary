using UnityEngine;
using System.Collections;

public class applyRandomForce : MonoBehaviour {

	public static string applyForceIn;
	float cooldown = 0;
	
	// Update is called once per frame
	void Update () {
		cooldown += Time.deltaTime;
		if (cooldown >= 0.5f) {
			cooldown = 0;
			if(applyForceIn == "verde" && this.gameObject.name == "verde"){
				this.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1*150,1*150),Random.Range(-1*150,1*150),Random.Range(-1*150,1*150)));
			}
			
			else if(applyForceIn == "vermelho" && this.gameObject.name == "vermelho"){
				this.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1*150,1*150),Random.Range(-1*150,1*150),Random.Range(-1*150,1*150)));
			}
			
			else if(applyForceIn == "azul" && this.gameObject.name == "azul") {
				this.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1*150,1*150),Random.Range(-1*150,1*150),Random.Range(-1*150,1*150)));
			}

		}
	}
}
