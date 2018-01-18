
using UnityEngine;
using System.Collections;

public class script_SettingPhoton : Photon.MonoBehaviour {

	public GUIStyle gS;
	public GameObject roomsObj;
	string textField;
	string textField1;

	void Start(){
		textField = "127.0.0.1";
		textField1 = "5055";
	}

	void OnGUI(){

		GUI.skin.textField.fontSize = 66;
		textField = GUI.TextField (new Rect (279,231,338,85), textField);
		textField1 = GUI.TextField (new Rect (279,365,338,85), textField1);

	}

	public void Connect(){
		PhotonNetwork.PhotonServerSettings.ServerAddress = textField;
		PhotonNetwork.PhotonServerSettings.ServerPort = int.Parse(textField1);
		this.gameObject.SetActive (false);
		roomsObj.SetActive (true);
	}
}
