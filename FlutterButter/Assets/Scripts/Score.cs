using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public AudioClip normalSound;
	public AudioClip newBestSound;

    private GameManager gameMan;
	private AudioSource audio;

	void Start () {
        gameMan = GameObject.Find("GameManager").GetComponent<GameManager>();
		audio = GetComponent<AudioSource> ();
		audio.clip = normalSound;
	}
	
	void Update () {
		
	}

	void NewBestSound(){
		gameMan.newBestScore = true;
		audio.clip = newBestSound;
		audio.Play ();
		Debug.Log("NEWBEST");
	}

	void NormalSound(){
		audio.clip = normalSound;
		audio.Play ();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player") {

			audio.clip = normalSound;

			if (!gameMan.newBestScore && gameMan.score >= gameMan.bestScore) {
				NewBestSound ();
			} else {
				NormalSound ();
			}


			gameMan.score++;
			//audio.Play ();
		}
    }
}
