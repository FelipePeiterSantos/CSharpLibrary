using UnityEngine;
using System.Collections;

public class GemPrefabScript : MonoBehaviour {

	private float tempoVida;
	public float tempoMaximoVida;
	private Score score;
	private Gerenciador gerenciador;


	void Awake(){
		score = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
		gerenciador = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
	}

	// Use this for initialization
	void Start () {
		tempoVida = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		tempoVida += Time.deltaTime;
		if (tempoVida >= tempoMaximoVida) {
			Destroy(gameObject);
			tempoVida=0;
			}
	
	}
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Player") {
			score.Add(2);
			gerenciador.AddQuantidade(1);
			Destroy(gameObject);
		}
	}
}
