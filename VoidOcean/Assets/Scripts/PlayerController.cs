using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Header("Player Movement")]
	[Space(2)]
	public float speedVertical = 8f;
	public float speedHorizontal = 10f;

	[Header("Bullets")]
	[Space(2)]
	public GameObject bullet;

	//public float fireDelta = 0.5f;
	public float fireRate = 0.5f;

	private float nextFire = 0.5f;
	private float myTime = 0.0f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		var pos = transform.position;

		myTime = myTime + Time.deltaTime;

		if (Input.GetButton ("Fire1") && myTime > nextFire) {
			//var mousePos = Input.mousePosition;
			//mousePos.z = 2.0f;
			//mousePos.x = Random.Range (mousePos.x - 6, mousePos.x + 6);

			AudioManager.instance.Play ("Shoot");

			nextFire = myTime + fireRate;

			var objectPos = pos;//Camera.main.ScreenToWorldPoint (pos); //.current.ScreenToWorldPoint (mousePos);
			objectPos.z = 2.0f;
			objectPos.y += .7f;

			Instantiate (bullet, objectPos, Quaternion.identity);
		
			nextFire = nextFire - myTime;
			myTime = 0.0f;
		}

	}

	void FixedUpdate(){

		var horizontal = Input.GetAxisRaw ("Horizontal") * speedHorizontal;
		var vertical = Input.GetAxisRaw ("Vertical") * speedVertical;
		rb.AddForce (new Vector2 (horizontal, vertical));

	}
}
