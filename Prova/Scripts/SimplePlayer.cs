using UnityEngine;
using System.Collections;

public class SimplePlayer : MonoBehaviour {
	public float velocidade=10f;
	public bool facingRight = true; 
	

	
	Animator anim;
	// Use this for initialization
	void Start () {
		//Captura o componente animator para setar parametros para definir animaçao executada
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		Mov ();
	}
	void Mov()
	{
		float move= Input.GetAxis("Horizontal");
		//Debug.Log (move);
		
		//O metodo Math.Abs recupera o valor absoluto do numero(sem sinal) 
		//para setar no objeto anim(recupera animator)
		//para passar valor do parametro Speed
		//anim.SetFloat ("Speed", Mathf.Abs (move));
		
		anim.SetFloat("Speed",Mathf.Abs (move));

		if (Input.GetAxisRaw ("Horizontal") > 0 | Input.GetKey(KeyCode.G)) 
		{
			transform.Translate(Vector2.right*velocidade*Time.deltaTime);
			transform.eulerAngles= new Vector2(0,0);
		}
		if (Input.GetAxisRaw ("Horizontal") < 0 | Input.GetKey(KeyCode.J)) 
		{
			transform.Translate(Vector2.right*velocidade*Time.deltaTime);
			transform.eulerAngles= new Vector2(0,180);
		}
	}
}
