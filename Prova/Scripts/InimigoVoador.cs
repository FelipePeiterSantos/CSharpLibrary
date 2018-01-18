using UnityEngine;
using System.Collections;

public class InimigoVoador : MonoBehaviour {

	
	
	public GameObject objeto;
	private bool isLeft=true;
	public float velocidade=5f;
	public float maxDelay;
	private float timeMove=0f;
	
	
	public Transform verticeInicial;
	public Transform verticeFinal;
	public bool isAlvo;
	
	private float mxDelayObject = 0.004f;
	private float timeObject = 10f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Mov ();
		RayCasting ();
		Behaviours ();
	}
	
	//metodo para detectar alvo
	void RayCasting(){
		Debug.DrawLine (verticeInicial.position, verticeFinal.position, Color.red);
		isAlvo = Physics2D.Linecast (verticeFinal.position, verticeInicial.position, 1 << LayerMask.NameToLayer ("Player"));

	}
	void Behaviours(){
		if (isAlvo) {
			if (timeObject <= mxDelayObject) {
				timeObject += Time.deltaTime;	
				Instantiate(objeto,verticeInicial.position,objeto.transform.rotation);
			}
		}else{
			timeObject=0;
		}
	}
	
	void Mov(){
		timeMove += Time.deltaTime;
		if (timeMove <= maxDelay) {
			if (isLeft) {
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 0);
			} else {
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 180);
			}
		} else {
			isLeft=!isLeft;
			timeMove=0;
		}
	}
}
