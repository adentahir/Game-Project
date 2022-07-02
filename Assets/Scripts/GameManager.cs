﻿//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//using System.Collections;
//using System.Collections.Generic;

//public class GameManager : MonoBehaviour {

//	public Sprite[] cardFace;
//	public Sprite cardBack;
//	public GameObject[] cards;
//	public GameObject gameTime;
//	public LevelManager instance;
//	private bool _init  = false;
//	[SerializeField]
//	int _matches = 4;
//	[SerializeField]
//	int _id =5;

//    private void Start()
//    {
//		instance = FindObjectOfType<LevelManager>();

//    }
//    // Update is called once per frame
//    void Update () {
//		if (!_init)
//			initializeCards ();

//		if (Input.GetMouseButtonUp(0))
//			checkCards ();

//	}

//	void initializeCards() {
//		for (int id = 0; id < 2; id++) {
//			for (int i = 1; i < _id; i++) {

//				bool test = false;
//				int choice = 0;
//				while (!test) {
//					choice = Random.Range (0, cards.Length);
//					test = !(cards [choice].GetComponent<cardScript>().initialized);
//				}
//				cards [choice].GetComponent<cardScript> ().cardValue = i;
//				cards [choice].GetComponent<cardScript> ().initialized = true;
//			}
//		}

//		foreach (GameObject c in cards)
//			c.GetComponent<cardScript> ().setupGraphics ();

//		if (!_init)
//			_init = true;
//	}

//	public Sprite getCardBack() {
//		return cardBack;
//	}

//	public Sprite getCardFace(int i) {
//		return cardFace[i - 1];
//	}

//	void checkCards() {
//		List<int> c = new List<int> ();

//		for (int i = 0; i < cards.Length; i++) {
//			if (cards[i].GetComponent<cardScript>().state == 1)
//				c.Add(i);
//		}

//		if (c.Count == 2)
//			cardComparison(c);
//	}

//	void cardComparison(List<int> c){
//		cardScript.DO_NOT = true;

//		int x = 0;
//		// Checking for first card value with the second one
//		if (cards[c[0]].GetComponent<cardScript>().cardValue == cards[c[1]].GetComponent<cardScript>().cardValue) {
//			x = 2;
//			_matches--;
//			if (_matches == 0)
//			{
//				var s = SceneManager.GetActiveScene().buildIndex - 2;
//				if (!LevelManager.levelCom[s])
//				{
//					gameTime.GetComponent<timeScript>().setHighScore(s);

//				}
//				else gameTime.GetComponent<timeScript>().setHighScore2(s);
//				LevelManager.levelCom[s] = true;
//				PlayerPrefs.SetInt("Level" + s.ToString(), 1);
//				PlayerPrefs.Save();
				

//				gameTime.GetComponent<timeScript>().endGame();
				
//			}
//		}


//		for (int i = 0; i < c.Count; i++) {
//			cards [c[i]].GetComponent<cardScript>().state = x;
//			cards [c[i]].GetComponent<cardScript>().falseCheck();
//		}
	
//	}

//	public void reGame(){
//		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//	}

//	public void reMenu(){
//		SceneManager.LoadScene ("LevelScene");
//	}
//}
