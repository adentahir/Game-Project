﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

	public void triggerMenu(int trigger) {
		switch (trigger) {
		case(0) :
			SceneManager.LoadScene("LevelScene");
			break;
		case(1) :
			Application.Quit();
			break;

		case(2):

				break;
		}
	}
}
