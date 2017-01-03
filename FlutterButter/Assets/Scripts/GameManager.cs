using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Text deathText;
    public Text scoreText;
	public Text bestScoreText;
    
    public Text endScoreText;

    public int score = 0;
	public int bestScore;

    public bool gameOver = false;
	public bool newBestScore = false;

	public Color gold;
	public Color purple;

    public static GameManager instance;

	private Bird bird;
	private Animator anim;
	private bool killed = false;
	public Shadow bestShadow;

	void Start () {
        anim = GameObject.Find("burd").GetComponent<Animator>();
        bird = GameObject.Find("burd").GetComponent<Bird>();

		// singleton pattern. Use "GameManager.instance.(method or variable)"
        if(instance == null)
        {
            instance = this;
        }
        score = 0;

		bestScore = PlayerPrefs.GetInt ("BestScore", 0);
		//PlayerPrefs.SetInt("BestScore", 0);
		//PlayerPrefs.Save ();

	}
	
	
	void Update () {
		if (bird.isDead && !killed) {
			onBirdKilled ();
			killed = true;
		} else if (bird.isDead) {
			//if(Input.anyKeyDown)
			//{
			//	SceneManager.LoadScene("Main");
			//}
		}



        //Debug.Log(score);   

        scoreText.text = "Score: " + score.ToString();
	}

	void onBirdKilled()
	{
		gameOver = true;
		endScoreText.text = "Final Score: " + score.ToString();

		if (score > bestScore) {
			Debug.Log ("NEW BEST SCORE " + score);
			bestScore = score;

			// normal color A500BF80
			bestShadow.effectColor = gold;

			bestScoreText.text = "New Best Score: " + bestScore.ToString ();
			PlayerPrefs.SetInt ("BestScore", bestScore);
			PlayerPrefs.Save ();

		} else {
			bestShadow.effectColor = purple;
			bestScoreText.text = "Best Score: " + bestScore.ToString ();
		}

		scoreText.gameObject.SetActive(false);

		deathText.gameObject.SetActive(true);

		anim.SetTrigger("DeadTrigger");




	}
}
