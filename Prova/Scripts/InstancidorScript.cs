using UnityEngine;
using System.Collections;

public class InstancidorScript : MonoBehaviour {

	public GameObject[] objetos;

	private bool dirEsquerda =true;
	public float velocidade = 5f;
	public float delayMovimento;
	public float instanciadorTempo =5f;
	public float instanciadorTempoDelay = 3f;
	private float tempoMovimento = 0f;
	public int valorMinRand = 0;



	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", instanciadorTempo, instanciadorTempoDelay);

	
	}
	
	// Update is called once per frame
	void Update () {
		Movimentar ();
	}
	void Spawn()
	{
		int index = Random.Range(valorMinRand,objetos.Length);
		Instantiate (objetos [index], transform.position, objetos [index].transform.rotation);
	}

	void Movimentar()
	{
		tempoMovimento += Time.deltaTime;
		if (tempoMovimento <= delayMovimento) 
		{
			if (dirEsquerda) {
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 0);
			} else {
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 180);
			}
		}
		else 
		{
			dirEsquerda=!dirEsquerda;
			tempoMovimento=0;
		}
	}
}
