using UnityEngine;
using System.Collections;

public class script_Alien : MonoBehaviour {

	public static float speed = 2;

	void Start () {
		this.gameObject.name = "Alien";
		GetComponent<Rigidbody2D>().velocity = new Vector2(-speed,0);
	}
	

	public void AumentarSpeed(){
		speed += 0.5f;
	}
}
