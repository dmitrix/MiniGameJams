using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

	private int bestScore;
	public Text bestScoreText;

	// Use this for initialization
	void Start () {
		bestScore = PlayerPrefs.GetInt ("BestScore", 0);
		bestScoreText.text = "Best Score: " + bestScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ResetScore() {
		bestScore = 0;
		PlayerPrefs.SetInt ("BestScore", 0);
		PlayerPrefs.Save ();
		bestScoreText.text = "Best Score: " + bestScore;
	}
}
