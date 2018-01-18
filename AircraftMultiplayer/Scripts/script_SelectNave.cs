using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using PhotonHashTable = ExitGames.Client.Photon.Hashtable;

public class script_SelectNave : Photon.MonoBehaviour {
	
	public GameObject otherNave;

	static bool isSelected;
	PhotonHashTable photonHashtable;
	Color spriteColor;
	Text waitText;

	void Start(){
		isSelected = false;
		photonHashtable = new PhotonHashTable();
		spriteColor = GetComponent<SpriteRenderer> ().color;
		waitText = GameObject.Find ("wait").GetComponent<Text>();	
	}

	void OnMouseDown(){
		if(this.gameObject.name == "naveVerde"){
			photonHashtable ["nave"] = "nave";
			photonView.RPC("isReadyToGo", PhotonTargets.AllBuffered);
		}
		else{
			photonHashtable ["nave"] = "nave1";
			photonView.RPC("isReadyToGo", PhotonTargets.AllBuffered);
		}
		PhotonNetwork.SetPlayerCustomProperties(photonHashtable);
		otherNave.GetComponent<BoxCollider2D> ().enabled = false;
	}

	[PunRPC]
	public void isReadyToGo(){
		if(isSelected){
			PhotonNetwork.LoadLevel("Game");
		}

		if(photonView.isMine){
			waitText.text = "Aguardando outro jogador";
		}
		isSelected = true;
		GetComponent<SpriteRenderer> ().color *= new Color (1, 1, 1, 0.2f);
		GetComponent<BoxCollider2D> ().enabled = false;
	}
}
