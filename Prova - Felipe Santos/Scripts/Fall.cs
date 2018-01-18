using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {


	private bool isFalling = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isFalling)
			transform.Translate(0, -2 * Time.deltaTime, 0);
	
	}

	public void StartFall()
	{
		isFalling = true;
	}

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			Application.LoadLevel(0);
		}
	}
}
