using UnityEngine;
using System.Collections;

public class script_Tiro : MonoBehaviour {

	public GameObject explosionAlien;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (15,0);
		if(script_Alien.speed < 9){
			script_Alien.speed += 0.5f;
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D coll) {
		if(coll.gameObject.name == "LimitScreen"){
			Destroy(this.gameObject);
		}
		if(coll.gameObject.name == "Alien"){
			Instantiate(explosionAlien,coll.transform.position,Quaternion.identity);
			Destroy(this.gameObject);
			Destroy(coll.gameObject);
		}
	}
}
