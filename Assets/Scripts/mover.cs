using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	private Transform tf; 
	public float speed;
	public float turnSpeed; 


	void Start () {
		tf = GetComponent<Transform>(); 
	}


	void Update ()
	{
		if (Input.GetKey (KeyCode.W)) {
			tf.Translate(Vector3.up * 0.05f);
		}
		if (Input.GetKey (KeyCode.S)) {
			tf.Translate (Vector3.down * 0.05f);
		}
		if (Input.GetKey (KeyCode.A)) {
			tf.Rotate (0, 0, turnSpeed);
		}
		if (Input.GetKey (KeyCode.D )){
			tf.Rotate (0, 0, -turnSpeed);
		}
		if (Input.GetKey (KeyCode.Space))
			tf.position = Vector3.zero;
	}
}  