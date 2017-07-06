using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTrigger : MonoBehaviour {
	Vector3 startPos = new Vector3 (-657,2,-584);
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
