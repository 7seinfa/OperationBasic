using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainHigh : MonoBehaviour {

	Text text;
	int highScore;

	void Start(){
		text = GetComponent<Text> ();
		highScore = globals.instance.highScore;
		text.text = "Highscore: " + highScore;
	}
}
