using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTrigger : MonoBehaviour {
	Vector3 endPos = new Vector3 (-657,2,-584);
	// Use this for initialization
	void Start () {
		endPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player") {
			other.gameObject.transform.position = endPos;
		}
	}
}
