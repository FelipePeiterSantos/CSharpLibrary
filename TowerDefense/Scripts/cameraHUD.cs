using UnityEngine;
using System.Collections;

public class cameraHUD : MonoBehaviour {

	public GameObject towerSelected;

	RaycastHit hit;
	//public GameObject currentTower;
	float raycastLength = 12;

	void Start(){
		//Inicia game com camera posicionada
		transform.position = new Vector3 (7.5f,transform.position.y,2);

		towerSelected = null;
	}

	void Update () {
		//Movimenta Camera
		if(Camera.main.ScreenToViewportPoint(Input.mousePosition).y > 0.95f && transform.position.x > 4.5f){
			transform.Translate(new Vector3(-0.1f,0,0));
		}
		else if(Camera.main.ScreenToViewportPoint(Input.mousePosition).y < 0.05f && transform.position.x < 10.5f){
			transform.Translate(new Vector3(0.1f,0,0));
		}

		if(Camera.main.ScreenToViewportPoint(Input.mousePosition).x > 0.95f && transform.position.z < 18.5f){
			transform.Translate(new Vector3(0,0,0.1f));
		}
		else if(Camera.main.ScreenToViewportPoint(Input.mousePosition).x < 0.05f && transform.position.z > 2f){
			transform.Translate(new Vector3(0,0,-0.1f));
		}


		//Raycast para reconhecimento da posiçao e click do mouse no mundo
		Ray rayLine = Camera.main.ScreenPointToRay (Input.mousePosition);
		if(Input.GetMouseButtonDown(0) && towerSelected){
			if(Physics.Raycast (rayLine,out hit, raycastLength, 1 << 12)){
				//Fazer nada
			}
			else if(Physics.Raycast (rayLine,out hit, raycastLength, 1 << 9)){
				//Fazer nada
			}
			else if (Physics.Raycast (rayLine,out hit, raycastLength, 1 << 11)){
				Instantiate(towerSelected,hit.point, Quaternion.identity);
				towerSelected = null;
			}
		}
		Debug.DrawRay (rayLine.origin, rayLine.direction * raycastLength);
	}
}
