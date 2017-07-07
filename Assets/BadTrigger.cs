using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTrigger : MonoBehaviour {
	Vector3 startPos = new Vector3 (-30,2,20);
	Vector3 endPos = new Vector3 (-657,2,-584);
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "bad") {
			transform.position = startPos;
		}
		if (other.gameObject.tag == "good") {
			transform.position = endPos;
		}
	}
}