﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour {
	public static GameManager instance = null;

	[SerializeField] private GameObject mainMenu;

	private bool playerActive = false;
	private bool gameOver = false;
	private bool gameStarted = false;

	public bool PlayerActive {
		get{return playerActive; }
	}

	public bool GameOver {

		get{return gameOver; }
	}
	public bool GameStarted{

		get{return gameStarted; }
	}



	void Awake(){
		if (instance == null) {
			instance = this;
		}
		else if(instance!=null){
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);

		Assert.IsNotNull (mainMenu);
	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerCollide(){
		gameOver = true;

	
	}

	public void PlayerStartedGame(){
		playerActive = true;
	
	}
	public void EnterGame(){

		mainMenu.SetActive (false);
		gameStarted = true;


	}
}
