using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public AudioClip collisionBullet;

	void OnCollisionEnter(Collision coll){
		AudioSource.PlayClipAtPoint (collisionBullet,coll.transform.position);
		Destroy (this.gameObject);
	}
}
