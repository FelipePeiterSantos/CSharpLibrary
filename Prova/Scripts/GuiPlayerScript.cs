using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System;

public class GuiPlayerScript : MonoBehaviour {
	private string textFieldString = "";
	private int pontFieldInt = 0;
	private Vector2 scrollViewVector = Vector2.zero;
	private string innerText = "";
	string strFileXML = "RankingPlayers.xml";
	private Gerenciador gerencidor;

	private Score score;
	
	
	void Awake(){
		score = GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
	}
	


	void OnGUI () {
		//Captura componente Script score
		//score=GameObject.FindGameObjectWithTag("Pontos").GetComponent<Score>() as Score;
		//Captura componente Script score
		pontFieldInt = score.Pontos();

		// Make a group on the center of the screen
		GUI.BeginGroup (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300));
		GUI.Box (new Rect (0,0,300,300), "Adiciona Pontos XML");
		// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		GUI.Label (new Rect (25, 25, 100, 30), "Nome:");
		textFieldString = GUI.TextField (new Rect (90, 25, 200, 30), textFieldString);
		GUI.Label (new Rect (25, 60, 100, 30), "Ponto: "+pontFieldInt.ToString());
		if (GUI.Button (new Rect (190, 95, 100, 30), "Adiciona")) 
		{
			Add(pontFieldInt,textFieldString);
			//View();
			gerencidor.ProximoLevel (gerencidor.proximoLevel);
			Score.Init();
		}

		GUI.EndGroup ();
	}

	// Use this for initialization
	void Start () {
		gerencidor = FindObjectOfType (typeof(Gerenciador)) as Gerenciador;
	}
	// Update is called once per frame
	void Update () {
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
	 
	public void Add(int _ponto, string _nome)
	{
		Player a = new Player ();
		Ranking r = new Ranking ();
		if(File.Exists(strFileXML))
		{
			r = XmlSupport.Deserialize<Ranking>(strFileXML);
		}
		a.nome=_nome;
		a.ponto = _ponto;
		r.players.Add (a);
		XmlSupport.Serialize<Ranking> (strFileXML,r);


	}
}
