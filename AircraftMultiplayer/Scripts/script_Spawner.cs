using UnityEngine;
using System.Collections;

public class script_Spawner : Photon.MonoBehaviour {

	public GameObject alien;

	float timer = 0;
	float spawnTime = 5f;

	void Start(){
		StartCoroutine ("WIN");
		script_Alien.speed = 2f;
	}

	void Update () {
		if(timer < spawnTime - (script_Alien.speed / 2)){
			timer += Time.deltaTime;
		}
		else{
			float rnd = Random.Range(0f,1f);
			Vector2 posRnd = Camera.main.ViewportToWorldPoint(new Vector2(0,rnd));
			PhotonNetwork.Instantiate(alien.name,new Vector2(transform.position.x,posRnd.y),Quaternion.identity,0);
			timer = 0;
		}
	}

	IEnumerator WIN(){
		yield return new WaitForSeconds (60);
		PhotonNetwork.LoadLevel ("Vitoria");
	}
}
