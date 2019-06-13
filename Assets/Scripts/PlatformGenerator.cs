using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	//the path that will be generated
	public GameObject path;
	//the point at which the path will be generated, moves with camera
	public Transform generationPoint;
	//distance between each path; leave this at default
	public float distanceBetween;
	//the path height, so we know when to duplicate the path
	private float pathHeight;
	//object pooler reference
	//public ObjectPool objPool;

	public GameObject[] paths;

	private int platformSelector;

	void Start(){
		//get path height from path collider
		pathHeight = path.GetComponent<BoxCollider2D>().size.y;
	}

	void FixedUpdate(){
		/*if this object's y is lower/less than the generation point's y, 
		change this object's position to where the next path will be, and grab an old inactive path and place it*/
		if (transform.position.y < generationPoint.position.y) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + pathHeight + distanceBetween, transform.position.z);

			platformSelector = Random.Range (1, paths.Length);

			Instantiate (paths[platformSelector], transform.position, transform.rotation);

			/*GameObject newPath =objPool.getPooledObject();
			
			newPath.transform.position = transform.position;
			newPath.transform.rotation = transform.rotation;
			newPath.SetActive (true);*/

		}
	}
}
