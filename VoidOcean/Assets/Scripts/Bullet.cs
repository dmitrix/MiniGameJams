using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour {

	[Header("Bullet Velocity")]
	public float forwardSpeed = 10f;
	public float randomRange = 4;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (Random.Range(-randomRange, randomRange), forwardSpeed);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
}
