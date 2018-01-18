using UnityEngine;
using System.Collections;

public class rocketLauncher : MonoBehaviour {

	public GameObject bullet;
	public Transform spawnBullet;
	float cooldownShoot = 0f;
	
	void Update () {
		cooldownShoot += Time.deltaTime;
	}

	void OnTriggerStay(Collider coll){
		if(coll.gameObject.tag == "car"){
			transform.LookAt(coll.transform.position);
			if(cooldownShoot > 1f){
				GameObject aux = Instantiate(bullet,spawnBullet.position,Quaternion.identity) as GameObject;
				aux.GetComponent<bullet>().target = coll.transform;
				aux.gameObject.name = bullet.gameObject.name;
				cooldownShoot = 0;
			}
		}
	}
}
