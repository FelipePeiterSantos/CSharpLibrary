using UnityEngine;
using System.Collections;

public class attackCar_sensor : MonoBehaviour {

	public GameObject bullet;
	public GameObject currentCar;
	float cooldownShoot = 0f;
	
	void Update () {
		cooldownShoot += Time.deltaTime;
	}
	
	void OnTriggerStay(Collider coll){
		if(coll.gameObject.tag == "tower"){
			currentCar.GetComponent<NavMeshAgent>().speed = 0f;
			transform.LookAt(coll.transform.position);
			if(cooldownShoot > 0.5f){
				GameObject aux = Instantiate(bullet,transform.position,Quaternion.identity) as GameObject;
				aux.GetComponent<bullet>().target = coll.transform;
				aux.gameObject.name = bullet.gameObject.name;
				cooldownShoot = 0;
			}
		}
	}
}
