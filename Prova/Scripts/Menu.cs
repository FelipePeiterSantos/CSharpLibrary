using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System;

public class Menu : MonoBehaviour {
	
	
	//public GUISkin skinMenu;

	private Vector2 scrollViewVector = Vector2.zero;
	private string innerText = "";
	string strFileXML = "RankingPlayers.xml";
	
	
	private Gerenciador gerencidor;


	private Score score;
	
	
	void Awake(){
		score = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
	}

	
	// Use this for initialization
	void Start () {
		gerencidor = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
		View ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnGUI()
	{
		GUI.BeginGroup (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300));


		scrollViewVector = GUI.BeginScrollView (new Rect (25, 130, 260, 150), scrollViewVector, new Rect (25, 130, 400, 400));
		// Put something inside the ScrollView
		innerText = GUI.TextArea (new Rect (25, 130, 400, 400), innerText);

		GUI.EndScrollView();
		GUI.EndGroup ();

		bool play = GUI.Button (new Rect (Screen.width - 164, Screen.height - 100, 64, 64), "Play");
		bool sair = GUI.Button (new Rect (Screen.width - 264, Screen.height - 100, 64, 64), "Sair");
		
		
		if (play) 
		{
			gerencidor.ProximoLevel (gerencidor.proximoLevel);
			Score.Init();
		}
		if (sair) 
		{
			Application.Quit();
		}
	}
	public void View()
	{
		//Player a = new Player ();
		innerText = "";
		Ranking r = new Ranking ();
		if(File.Exists(strFileXML))
		{
			r = XmlSupport.Deserialize<Ranking>(strFileXML);
		}
		if (!r.Equals (null)) 
		{
			foreach (var item in r.players) 
			{
				innerText += item.nome+" - "+item.ponto.ToString()+"\n"; 
			}
		}
	}
}
