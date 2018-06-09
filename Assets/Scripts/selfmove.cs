using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfmove : MonoBehaviour {
	private Transform tf;
	private float speed; // A variable to hold our Transform component
	void Start() {
		// Get the Transform Component
		tf = GetComponent<Transform>();
	}
	void Update() {
		// Move up every frame draw n
		tf.position = tf.position + Vector3.right * .05f ; // Vector3.up (0,1,0) 
		
	} 
}