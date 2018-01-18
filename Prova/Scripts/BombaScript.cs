using UnityEngine;
using System.Collections;

public class BombaScript : MonoBehaviour {

	
	
	public int ponto =2;
	public float tempoMaxLife;
	public float tempoLife;
	
	//private Vidas vida;
	private Score score;
	private Gerenciador gerenciador;
	
	
	
	void Awake(){
		score=GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
		gerenciador = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tempoLife += Time.deltaTime;
		if (tempoLife >= tempoMaxLife) {
			Destroy(gameObject);
			tempoLife=0;
		}
		
	}
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Player") {
			//vida=GameObject.FindGameObjectWithTag("Vidas").GetComponent<Vidas>() as Vidas;
			//if(vida.ExcluirVida()){
			//	score.RemScore(ponto);
		//	Destroy(gameObject);
		//	}
		//	else{
		//		gerenciador.GameOver("GameOver");
		//	}
		}
	}
}
