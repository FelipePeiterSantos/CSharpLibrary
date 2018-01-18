using UnityEngine;
using System.Collections;

public class inimigoScript : MonoBehaviour {

	public GameObject inimigoSpawn;
	public AudioClip destroy;

	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.tag == "bullet"){
			Destroy(this.gameObject);
			AudioSource.PlayClipAtPoint(destroy, transform.position);
			if(this.gameObject.name == "jose1PF"){
				Instantiate (inimigoSpawn,transform.position, Quaternion.identity);
			}
		}
	}
}
