using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gives a game object constant velocity if game is not over
[RequireComponent (typeof(Rigidbody2D))]
public class Scrolling : MonoBehaviour {

    public float scrollSpeed = 5f;

    private Rigidbody2D rb2d;
    private GameManager gameMan;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		// only scroll when the game is not over
		if (!GameManager.instance.gameOver)
			rb2d.velocity = new Vector2 (-scrollSpeed, 0);
		else
			rb2d.velocity = new Vector2 (0, 0);
	}
}
