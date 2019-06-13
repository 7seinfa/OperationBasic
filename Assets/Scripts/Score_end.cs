using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_end : MonoBehaviour {

	Text text;
	int score;
	int highScore;

	void Start(){
		text = GetComponent<Text> ();
		score = globals.instance.score;
		highScore = globals.instance.highScore;
		text.text = "Score: " + score + "\n Highscore: " + highScore;
	}

}
