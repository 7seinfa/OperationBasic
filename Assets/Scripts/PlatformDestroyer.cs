using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	//the point at which the path will be destructed, moves with camera
	public GameObject platformDestructionPoint;

	void Start(){
		//find the destruction point, without setting it
		platformDestructionPoint = GameObject.Find ("PlatformDestructionPoint");
	}

	void Update(){
		//if this object's position is lower/less than the destruction point, deactivate the path
		if (transform.position.y < platformDestructionPoint.transform.position.y) {
			Destroy (gameObject);
			//gameObject.SetActive(false);
		}
	}
}
