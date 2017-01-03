using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	private PlayerController pc;
	//private AudioSource audio;

	// Use this for initialization
	void Start () {
		pc = GameObject.Find ("Player").GetComponent<PlayerController> ();
		//audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			//Debug.Log ("POWER UP");
			pc.fireRate = .1f;

			AudioManager.instance.Play ("PowerUp");

			Destroy (gameObject);
		}
	}
}
