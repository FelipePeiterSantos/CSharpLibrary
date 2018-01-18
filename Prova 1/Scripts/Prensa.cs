using UnityEngine;
using System.Collections;

public class Prensa : MonoBehaviour {
	
	private bool ligada = false;
	public GameObject[] alavancas;


	void Update () {
		
		if(ligada)
		{
			transform.Translate(0, -1f * Time.deltaTime, 0);
		}

		bool aux = true;
		foreach (GameObject item in alavancas) {
			if(item){
				aux = false;
			}
		}

		if(aux){
			Destroy(this.gameObject);
		}


	}
	
	public void AtivaPrensa()
	{
		ligada = true;
		this.GetComponent<AudioSource>().Play();
	}

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "First Person Controller"){
			Application.LoadLevel(0);
		}
	}
}
