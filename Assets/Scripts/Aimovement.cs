using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimovement : MonoBehaviour {
    private Transform tf;

    private float speed; // Transform component variable 
    void Start()
    {
        // Get the Transform Component
        tf = GetComponent<Transform>();
    }
    void Update()
    {
        // Move up every frame 
        tf.position = tf.position + Vector3.left * .05f; // Vector3.up is (0,1,0) 
    }                    
}