using UnityEngine;
using System.Collections;

public class castleLife : MonoBehaviour {

	public GameObject winFlames;
	public GameObject Panel;

	int life = 1;

	void Damaged(){
		--life;
		if(life <= 0){
			Instantiate(winFlames,transform.position,Quaternion.identity);
			Destroy(this.gameObject);
			GameObject[] cars = GameObject.FindGameObjectsWithTag("car");
			foreach (GameObject car in cars) {
				Instantiate(winFlames,car.transform.position,Quaternion.identity);
				Panel.SendMessage ("ResetGame");
				Destroy(car.gameObject);
			}
		}
	}
}
