﻿using UnityEngine;
using System.Collections;

public class CameraFol : MonoBehaviour {
	
	
	public Transform player;
	public float smooth = 0.5f;
	private Vector2 velocidade;
	
	
	// Use this for initialization
	void Start () {
		velocidade = new Vector2 (0.5f, 05f);
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 novaPosicao2D = Vector2.zero;
		//Suavisando a posiçao
		novaPosicao2D.x = Mathf.SmoothDamp (transform.position.x, player.position.x, ref velocidade.x, smooth);
		novaPosicao2D.y = Mathf.SmoothDamp (transform.position.y, player.position.y+1.5f, ref velocidade.y, smooth);
		
		Vector3 novaPosicao = new Vector3 (novaPosicao2D.x, novaPosicao2D.y, transform.position.z);
		//	Slerp forma de interpolaçao nao linear
		// Lerp forma de interpolaçao linear
		transform.position = Vector3.Slerp (transform.position, novaPosicao, Time.time);
		//transform.position = Vector3.Lerp (transform.position, novaPosicao, Time.time);
	}
}