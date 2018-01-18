using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class Gerenciador : MonoBehaviour
{

	public Vector2 posicaoInicialPlayer;
	public Transform player;
	public int levelAtual;
	public int proximoLevel;
	public int quantidadeColetado = 0;
	private int quantidadeMaxima = 10;
	
	
	// Use this for initialization
	void Awake ()
	{
		if (player != null) {
			posicaoInicialPlayer = player.position;
		}
		quantidadeMaxima = 5;
		
	}
	
	void Start ()
	{
		
		//Debug.Log ("Start!!!!!");
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}
	
	public bool isColetado ()
	{
		if (quantidadeColetado >= quantidadeMaxima) {
			return true;
		} else {
			return false;
		}
	}
	
	public void StartGame ()
	{
		player.position = posicaoInicialPlayer;
	}
	
	public void GameOver (string nome)
	{
		Application.LoadLevel (nome);
	}
	
	public void AddQuantidade (int quantidade)
	{
		quantidadeColetado += quantidade;
	}
	
	public void ProximoLevel (int level)
	{
		Application.LoadLevel (level);
		
	}
	

}
