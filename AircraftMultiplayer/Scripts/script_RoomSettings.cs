using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class script_RoomSettings : Photon.MonoBehaviour {

	public int[] guides;
	string textField = "";
	string textField1 = "";
	public Text[] painelSalas;
	public GameObject[] btnSalas;

	void Start(){
		PhotonNetwork.ConnectUsingSettings ("0.1");
		PhotonNetwork.autoJoinLobby = true;
		PhotonNetwork.automaticallySyncScene = true;
		textField = "Convidado" + Random.Range (1, 999);
		textField1 = "Sala" + Random.Range (1, 999);
	}

	void Update(){
		if(PhotonNetwork.GetRoomList().Length == 0){
			foreach (Text item in painelSalas) {
				item.text = "";
			}
			foreach (GameObject item in btnSalas) {
				item.SetActive(false);
			}
			painelSalas[0].text = "Nenhuma sala disponivel.";
		}
		else{
			for (int i = 0; i < PhotonNetwork.GetRoomList().Length; i++) {
				RoomInfo roomInfo = PhotonNetwork.GetRoomList()[i];
				painelSalas[i].text = "Sala: " + roomInfo.name + "     Players Online: " + roomInfo.playerCount + "/" + roomInfo.maxPlayers;
				btnSalas[i].SetActive(true);
			}
		}
	}

	void OnGUI(){
		GUI.skin.textField.fontSize = 18;
		textField = GUI.TextField (new Rect(315,160,390,29),textField);
		textField1 = GUI.TextField (new Rect(315,190,390,29),textField1);
	}

	public void CriarSala(){
		RoomOptions roomOptions = new RoomOptions (){maxPlayers = 2, isVisible = true}; 
		PhotonNetwork.CreateRoom(textField1 , roomOptions , TypedLobby.Default);
		PhotonNetwork.GetRoomList ();
	}
	public void EntrarSala(int aux){
		PhotonNetwork.JoinRoom (PhotonNetwork.GetRoomList()[aux].name);
	}


	void OnConnectedToPhoton (){
		Debug.Log ("OnConnectedToPhoton");
	}
	
	void OnLeftRoom (){
		Debug.Log ("OnLeftRoom");
	}
	
	void OnMasterClientSwitched (){
		Debug.Log ("OnMasterClientSwitched");
	}
	
	void OnPhotonCreateRoomFailed (){
		Debug.Log ("OnPhotonCreateRoomFailed");
	}
	
	void OnPhotonJoinRoomFailed (){
		Debug.Log ("OnPhotonJoinRoomFailed");
	}
	
	void OnCreatedRoom (){
		Debug.Log ("OnCreatedRoom");
	}
	
	void OnJoinedLobby (){
		Debug.Log ("OnJoinedLobby");		
	}
	
	void OnLeftLobby (){
		Debug.Log ("OnLeftLobby");
	}
	
	void OnDisconnectedFromPhoton (){
		Debug.Log ("OnDisconnectedFromPhoton");
	}
	
	void OnConnectionFail (){
		Debug.Log ("OnConnectionFail");
	}
	
	void OnFailedToConnectToPhoton (){
		Debug.Log ("OnFailedToConnectToPhoton");
	}
	
	void OnReceivedRoomListUpdate (){
		Debug.Log ("OnReceivedRoomListUpdate");
	}
	
	void OnJoinedRoom (){
		Debug.Log ("OnJoinedRoom");
		PhotonNetwork.LoadLevel ("SelecionarNave");
	}
	
	void OnPhotonPlayerConnected (){
		Debug.Log ("OnPhotonPlayerConnected");
	}
	
	void OnPhotonPlayerDisconnected (){
		Debug.Log ("OnPhotonPlayerDisconnected");
	}
	
	void OnPhotonRandomJoinFailed (){
		Debug.Log ("OnPhotonRandomJoinFailed");
	}
	
	void OnConnectedToMaster (){
		Debug.Log ("OnConnectedToMaster");
	}
	
	void OnPhotonSerializeView (){
		Debug.Log ("OnPhotonSerializeView");
	}
	
	void OnPhotonInstantiate (){
		Debug.Log ("OnPhotonInstantiate");
	}
	
	void OnPhotonMaxCccuReached (){
		Debug.Log ("OnPhotonMaxCccuReached");
	}
	
	void OnPhotonCustomRoomPropertiesChanged (){
		Debug.Log ("OnPhotonCustomRoomPropertiesChanged");
	}
	
	void OnPhotonPlayerPropertiesChanged (){
		Debug.Log ("OnPhotonPlayerPropertiesChanged");
	}
	
	void OnUpdatedFriendList (){
		Debug.Log ("OnUpdatedFriendList");
	}
	
	void OnCustomAuthenticationFailed (){
		Debug.Log ("OnCustomAuthenticationFailed");
	}
	
	void OnWebRpcResponse (){
		Debug.Log ("OnWebRpcResponse");
	}

}
