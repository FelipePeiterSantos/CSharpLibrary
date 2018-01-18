using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {


	public GameObject verde_PF;
	public GameObject vermelho_PF;
	public GameObject azul_PF;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnVerde(){
		GameObject aux = Instantiate (verde_PF,transform.position,Quaternion.identity) as GameObject;
		aux.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
		aux.gameObject.name = "verde";
	}

	public void spawnVermelho(){
		GameObject aux = Instantiate (vermelho_PF,transform.position,Quaternion.identity) as GameObject;
		aux.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
		aux.gameObject.name = "vermelho";
	}

	public void spawnAzul(){
		GameObject aux = Instantiate (azul_PF,transform.position,Quaternion.identity) as GameObject;
		aux.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
		aux.gameObject.name = "azul";
	}
}
