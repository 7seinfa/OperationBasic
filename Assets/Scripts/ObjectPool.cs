using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	//the object that will be pooled
	public GameObject pooledObject;

	//how many objects to be pooled (if not enough on this number, will automatically add more)
	public int pooledAmount;

	//list of pooled objects, kind of like an array
	List<GameObject> pooledObjectsList;

	void Start(){
		//initiate the object
		pooledObjectsList = new List<GameObject> ();

		//for interger i, if i is less than the pooled amound of objects, keep creating the object, until i is equal to the amound of objects on the list
		for(int i = 0; i < pooledAmount; i++){
			GameObject obj = (GameObject)Instantiate (pooledObject);
			obj.SetActive (false);
			pooledObjectsList.Add (obj);
		}
	}

	//for platform generator script, to grab pooled objects. For interger i, if i is less than the amount of objects in the list,
	//keep checking the list until an inactive object is found. if no object is found, create a new one
	public GameObject getPooledObject(){
		for (int i = 0; i < pooledObjectsList.Count; i++) {
			if (!pooledObjectsList [i].activeInHierarchy) {
				return pooledObjectsList[i];
			}
		}

		GameObject obj = (GameObject)Instantiate (pooledObject);
		obj.SetActive (false);
		pooledObjectsList.Add (obj);
		return obj;

	}

}
