using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class interfacePanel : MonoBehaviour {

	public GameObject torreAttack;
	public GameObject torreStun;
	public GameObject cameraHUD;

	public GameObject TXT_timeScript;
	float time = 0f;
	public GameObject TXT_pointScript;
	int points = 0;
	float pointsTime = 0f;

	bool resetGameCountdown = false;
	float resetGameCountdownTime = 0f;

	void Update () {
		time += Time.deltaTime;
		pointsTime += Time.deltaTime;
		if(pointsTime > 2f){
			++points;
			pointsTime = 0;
		}

		TXT_timeScript.GetComponent<Text> ().text = Mathf.Round( time).ToString ();
		TXT_pointScript.GetComponent<Text> ().text = points.ToString ();
		if(resetGameCountdown){
			resetGameCountdownTime += Time.deltaTime;
			if(resetGameCountdownTime > 15f){
				Application.LoadLevel(0);
			}
		}
	}

	void BT_stunTorre(){
		if(points >= 1){
			cameraHUD.GetComponent<cameraHUD>().towerSelected = torreStun;
			points -= 1;
		}
	}

	void BT_damageTower(){
		if(points >= 3){
			cameraHUD.GetComponent<cameraHUD>().towerSelected = torreAttack;
			points -= 3;
		}
	}

	void ResetGame(){
		resetGameCountdown = true;
	}
}
