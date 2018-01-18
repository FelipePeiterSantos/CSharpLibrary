using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using PhotonHashTable = ExitGames.Client.Photon.Hashtable;

public class script_NAve : Photon.MonoBehaviour {

	static bool otherIsDead;
	public GameObject tiro;
	public GameObject explosion;
	public Text vidas;
	bool started = true;
	int vida = 0;

	void Update () {
		if(started){
			started = false;
			OwnNave ();
		}
		if(photonView.isMine){
			if(Input.GetAxisRaw("Vertical") != 0){
				GetComponent<Rigidbody2D>().velocity = new Vector2(0,10*Input.GetAxisRaw("Vertical"));
			}
			
			if(Input.GetKeyDown(KeyCode.Space) && GetComponent<BoxCollider2D>().enabled){
				PhotonNetwork.Instantiate(tiro.name,new Vector2(transform.position.x + 1.5f,transform.position.y),Quaternion.identity,0);
			}
			
			if(Camera.main.WorldToViewportPoint(transform.position).y > 1){
				transform.position = new Vector2(transform.position.x, -5);
			}
			else if(Camera.main.WorldToViewportPoint(transform.position).y < 0){
				transform.position = new Vector2(transform.position.x, 5);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.name == "Alien"){
			GetComponent<Animator>().SetTrigger("hit");
		}
	}
	public void Explosion(){
		Instantiate (explosion,transform.position,Quaternion.identity);
		vida--;
		if(vida < 1){
			if(otherIsDead){
				PhotonNetwork.LoadLevel("Derrota");
			}
			else{
				photonView.RPC("DestroyNave",PhotonTargets.AllBuffered);
			}
		}
		photonView.RPC("UpdateVidas",PhotonTargets.AllBuffered,vida);
	}

	public void OwnNave(){
		vida = 5;
		otherIsDead = false;
		string choosedNave = PhotonNetwork.player.customProperties ["nave"].ToString ();
		if(choosedNave == "nave" && this.gameObject.name == "Nave" || choosedNave == "nave1" && this.gameObject.name == "Nave2"){
			photonView.TransferOwnership (PhotonNetwork.player.ID);
		}
	}

	[PunRPC]
	public void DestroyNave(){
		otherIsDead = true;
		PhotonNetwork.Destroy(this.photonView);
	}

	[PunRPC]
	public void UpdateVidas(int aux){
		vidas.text = aux.ToString ();
	}
}
