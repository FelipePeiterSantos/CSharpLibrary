using UnityEngine;
using System.Collections;

public class car : MonoBehaviour {

	public GameObject dieParticle;
	public AudioClip efxDie;

	int life = 5;
	float stun = 0;

	Vector3 target;
	Vector3 firstCheckpoint;
	Vector3 secondCheckpoint;
	Vector3 toCastle;


	void Start () {
		//Randomiza int
		int rndFirst = (int)Random.Range (0,3);
		int rndSecond = (int)Random.Range (0,3);
		GameObject[] checkpoints = GameObject.FindGameObjectsWithTag ("checkpoints");
		toCastle = GameObject.FindGameObjectWithTag ("castle").transform.position;

		//Escolhe caminho conforme int randomizada

		switch (rndFirst) {
		case 0:
			foreach (GameObject item in checkpoints) {
				if(item.gameObject.name == "center_1"){
					firstCheckpoint = item.transform.position;
				}
			}						
			break;
		case 1:
			foreach (GameObject item in checkpoints) {
				if(item.gameObject.name == "right_1"){
					firstCheckpoint = item.transform.position;
				}
			}
			break;
		case 2:
			foreach (GameObject item in checkpoints) {
				if(item.gameObject.name == "left_1"){
					firstCheckpoint = item.transform.position;
				}
			}
			break;
				
		}
		switch (rndSecond) {
		case 0:
			foreach (GameObject item in checkpoints) {
				if(item.gameObject.name == "center_2"){
					secondCheckpoint = item.transform.position;
				}
			}						
			break;
		case 1:
			foreach (GameObject item in checkpoints) {
				if(item.gameObject.name == "right_2"){
					secondCheckpoint = item.transform.position;
				}
			}
			break;
		case 2:
			foreach (GameObject item in checkpoints) {
				if(item.gameObject.name == "left_2"){
					secondCheckpoint = item.transform.position;
				}
			}
			break;
			
		}

		target = firstCheckpoint;


		this.GetComponent<NavMeshAgent>().speed = 0.5f;
	}

	void Update () {
		//Caminho a ir
		this.GetComponent<NavMeshAgent> ().SetDestination (target);

		stun -= Time.deltaTime;

		if(life <= 0){
			Destroy(this.gameObject);
			Instantiate(dieParticle,transform.position,dieParticle.transform.rotation);
			AudioSource.PlayClipAtPoint(efxDie,Camera.main.transform.position);
		}
		if(stun >= 0 && this.GetComponent<NavMeshAgent>().speed != 0){
			this.GetComponent<NavMeshAgent>().speed = 0.25f;
		}
		else{
			this.GetComponent<NavMeshAgent>().speed = 0.5f;
		}
	}

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.tag == "checkpoints" && target == firstCheckpoint){
			target = secondCheckpoint;
		}
		else if (coll.gameObject.tag == "checkpoints" && target == secondCheckpoint){
			target = toCastle;
		}
		if(coll.gameObject.tag == "castle"){
			Destroy(this.gameObject);
			AudioSource.PlayClipAtPoint(efxDie,transform.position);
			Instantiate(dieParticle,transform.position,dieParticle.transform.rotation);
			coll.SendMessage("Damaged");
		}
	}

	void Damaged(){
		--life;
	}

	void Stunned(){
		stun = 2f;
	}
}
