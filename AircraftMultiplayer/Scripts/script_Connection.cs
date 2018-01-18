using UnityEngine;
using System.Collections;

public class script_Connection : MonoBehaviour {
	
	void Start () {
		PhotonNetwork.ConnectUsingSettings ("0.0.1v");
		//PhotonNetwork.JoinRoom ("Test");
	}

	public void CriarSala(){
		RoomOptions roomOptions = new RoomOptions (){maxPlayers = 2};
		PhotonNetwork.CreateRoom ("test",roomOptions,new TypedLobby());
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
		CriarSala ();
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
		PhotonNetwork.JoinRoom ("test");
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
