using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTrigger : MonoBehaviour {
	Vector3 startPos = new Vector3 (-30,2,20);
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		transform.position = startPos;
	}
}