using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Simple class to make an object automatically scroll
 * 
 */

[RequireComponent (typeof (Rigidbody2D))]
public class Scrolling : MonoBehaviour {

	public Vector2 scrollVelocity = new Vector2 (0, 0);

	private Rigidbody2D rb2d;
	void Awake(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		rb2d.velocity = scrollVelocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
