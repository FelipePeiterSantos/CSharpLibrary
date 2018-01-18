using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	float timer = 0f;
	float cooldown = 0f;
	int spawnCount = 0;
	
	public GameObject attackCar;
	public GameObject runCar;

	void Start () {

	}

	void Update () {
		timer += Time.deltaTime;
		cooldown += Time.deltaTime;
		if(spawnCount >= 0 && timer >= 8f){
			SpawnCars ();
			timer = 0f;
		}
		else if(spawnCount >= 5 && timer >= 6f){
			SpawnCars ();
			timer = 0f;
		}
		else if(spawnCount >= 10 && timer >= 4f){
			SpawnCars ();
			timer = 0f;
		}
		else if(spawnCount > 20 && timer >= 2f){
			SpawnCars ();
			timer = 0f;
		}
	}

	void SpawnCars(){
		int rndCarSpawn = Random.Range (0,2);
		switch (rndCarSpawn) {
		case 0:
			Instantiate(attackCar,transform.position,attackCar.transform.rotation);
			break;
		case 1:
			Instantiate(runCar,transform.position,attackCar.transform.rotation);
			break;
		}
		++spawnCount;
	}
}
