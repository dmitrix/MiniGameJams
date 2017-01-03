using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class RepeatOffScreen : MonoBehaviour {

	private BoxCollider2D bc2d;
	private float verticalSize;
	private float scaleX;
	private float scaleY;

	void Start () {
		bc2d = GetComponent<BoxCollider2D> ();
		verticalSize = bc2d.size.y;

		scaleX = transform.localScale.x;
		scaleY = transform.localScale.y;

		//Debug.Log (verticalSize + " " + scaleX + "  " + scaleY);
	}
	
	void Update () {
		if (transform.position.y < -( verticalSize * scaleY)) {
			var pos = new Vector2(transform.position.x, verticalSize*scaleY);

			transform.position = (Vector2)pos;
		}
	}
}
