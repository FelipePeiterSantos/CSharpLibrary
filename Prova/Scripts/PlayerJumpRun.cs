using UnityEngine;
using System.Collections;

public class PlayerJumpRun : MonoBehaviour {

	public float velocidade;
	public Transform player;
	private Animator animator;
	
	
	public bool isGrouded;
	public float force;
	
	public float jumpTime = 1.1f;
	public float jumpDelay = 1.1f;
	
	public bool jumped=false;
	
	public Transform ground;
	
	private Gerenciador gerenciador;
	
	
	// Use this for initialization
	void Start () {
		//Captura objeto gerenciador 
		gerenciador = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
		animator = player.GetComponent<Animator>();
		//Inicia Gerenciador
		gerenciador.StartGame ();
	}
	
	// Update is called once per frame
	void Update () {
		Movimentar ();
	}
	
	void Movimentar(){
		isGrouded = Physics2D.Linecast(this.transform.position, ground.position, 1<<LayerMask.NameToLayer("Plat"));
		
		animator.SetFloat ("Speed",Mathf.Abs(Input.GetAxis("Horizontal")));
		
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate(Vector2.right*velocidade*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,0);
		}
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate(Vector2.right*velocidade*Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,180);
		}
		
		if (Input.GetButtonDown ("Jump") && isGrouded && !jumped ) {
			//if (Input.GetButtonDown ("Jump") && !jumped ) {
			//print ("space key was released");
			rigidbody2D.AddForce(transform.up * force);
			jumpTime=jumpDelay;
			animator.SetTrigger("jump");
			jumped=true;
		}
		jumpTime -= Time.deltaTime;
		if (jumpTime <= 0 && isGrouded && jumped) {
			animator.SetTrigger("ground");
			jumped=false;
		}
	}
	void OnCollisionEnter2D(Collision2D colisor){
		Debug.Log(colisor.gameObject.name);
		if (colisor.gameObject.tag=="Exit") {
			if(gerenciador.isColetado())
			{
				gerenciador.ProximoLevel(gerenciador.proximoLevel);  
			}
			else
			{
				Debug.Log("Falta coletar!");
			}
		}
	}
}
