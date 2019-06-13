using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globals : MonoBehaviour {

	public static globals instance;

	public Ball ball;
	public int score;
	public int highScore;

	void Awake(){
		instance = this;
		if (PlayerPrefs.HasKey ("HighScore")) {
			highScore = PlayerPrefs.GetInt ("HighScore");
		} else {
			PlayerPrefs.SetInt ("HighScore", 0);
			highScore = PlayerPrefs.GetInt ("HighScore");
		}
		DontDestroyOnLoad (this);
	}

	void FixedUpdate(){
		ball = Ball.instance;
		score = ball.points;
		if (score > highScore) {
			PlayerPrefs.SetInt ("HighScore", score);
			highScore = PlayerPrefs.GetInt ("HighScore");
		}
	}
}
