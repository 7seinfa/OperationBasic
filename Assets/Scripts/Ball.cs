using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	//onPath describes if the character is on the path (objects that aren't a path object must be tagged with nonPath)
	bool onPath;
	public int points;
	public static Ball instance;

	void Awake(){
		instance = this;
	}

	void Start(){
		//always start on path
		onPath = true;
		points = 0;
	}

	//distance is depth; 10 means it will be infront of any object with a depth less than 10
	float distance = 10;
	//once you click and drag the object
	void OnMouseDrag(){
		//only be draggable if character is on path
		if (onPath) {
			//this takes the x and y of the mouse, and the depth
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			//this changes the screen position of the mouse to the position in the game
			Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
			//finally move player to where ever the mouse goes
			transform.position = objPosition;
		}
	}
		
	//check collisions
	void OnTriggerEnter2D(Collider2D coll){
		//if it comes into contact with anything other than a path, set onPath to false
		if (coll.gameObject.tag == "nonPath") {
			onPath = false;
			Debug.Log ("col");
			SceneManager.LoadScene ("end");
		} else if (coll.gameObject.tag == "point") {
			points++;
			coll.gameObject.tag = "pointed";
		}
	}
}
