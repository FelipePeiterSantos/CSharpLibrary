using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;


public class Player {
	[XmlElement("nome")]
	public string nome;
	[XmlElement("ponto")]
	public int ponto;
}

public class Ranking
{
	[XmlElement("players")]
	public List<Player> players = new List<Player>(); 
}

