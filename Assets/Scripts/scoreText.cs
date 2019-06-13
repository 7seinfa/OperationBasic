using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour {

	public Ball ball;
	Text text;

	void Start () {
		text = GetComponent<Text> ();
		text.text = ball.points.ToString();
	}

	void FixedUpdate () {
		text.text = ball.points.ToString();
	}
}
