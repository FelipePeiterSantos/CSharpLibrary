using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {


	public static int ponto;
	public static Score minhaInstancia;

	void Awake(){
		minhaInstancia = this;
		}


	// Use this for initialization
	void Start () {
		guiText.text = "Pontos:" + ponto;
	}
	// Update is called once per frame
	void Update () {
	}

	public void Add(int arg){
		ponto+=arg;
		guiText.text = "Pontos:" + ponto;
	}

	public int Pontos(){
		return ponto;
	}
	public void Remove(int arg){
		ponto += arg;
		guiText.text = "Pontos:" + ponto;
	}

	public static void Init(){
		ponto=0;
	}
	

}
