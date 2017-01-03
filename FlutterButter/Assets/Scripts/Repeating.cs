using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moves scrolling background over to recycle it
[RequireComponent(typeof(BoxCollider2D))]
public class Repeating : MonoBehaviour {

	private BoxCollider2D collider;
	private float horizontalLength;

	void Start () {
		collider = GetComponent<BoxCollider2D> ();
		horizontalLength = collider.size.x;
	}
	
	void Update () {
		if (transform.position.x < -horizontalLength)
			RepositionBackground ();
	}

	private void RepositionBackground(){
		Vector2 offset = new Vector2 (horizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + offset;//transform.position + offset;
	}
}
