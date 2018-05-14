﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel(){
		Debug.Log ("Load next level");
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
	}
}
