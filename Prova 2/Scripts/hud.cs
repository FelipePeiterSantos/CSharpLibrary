using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hud : MonoBehaviour {

	GameObject criador;
	GameObject score;
	static int contador;

	void Start(){
		contador = 0;
		criador = GameObject.FindGameObjectWithTag ("criador");
		score = GameObject.FindGameObjectWithTag ("score");
		applyRandomForce.applyForceIn = "";
	}

	void Update(){
		score.GetComponent<Text> ().text = contador.ToString ();
		if(contador > 99){
			Application.LoadLevel(0);
		}
	}

	void OnMouseDown(){
		contador++;
		switch (this.gameObject.name) {
		case "azul": criador.SendMessage("spawnAzul");
			applyRandomForce.applyForceIn = "azul";
			break;
		case "vermelho": criador.SendMessage("spawnVermelho");
			applyRandomForce.applyForceIn = "vermelho";
			break;
		case "verde": criador.SendMessage("spawnVerde");
			applyRandomForce.applyForceIn = "verde";
			break;
		}

	}
}
