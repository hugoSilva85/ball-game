	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int scoreValue = 0;
	Text score;
	public GameObject gameWinBackGround;


	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " 	+ scoreValue;


		int total = GameObject.FindGameObjectsWithTag("blue").Length;
		int result =  scoreValue * total;

		if (scoreValue >= result){
			nextLevel();
		}
		
	}

	void nextLevel(){
		gameWinBackGround.SetActive(true);
	}
}
