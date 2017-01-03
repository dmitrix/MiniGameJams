using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public float upForce = 5f;
    public bool isDead = false;

	public AudioClip flapSound;
	public AudioClip deathSound;

    private Rigidbody2D rb2d;
    private PerlinShake shake;
    private bool isFlapping = false;

    private Animator anim;
	private AudioSource audio;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, upForce);
        shake = GameObject.Find("Main Camera").GetComponent<PerlinShake>();
        anim = GetComponent<Animator>();
		audio = GetComponent<AudioSource> ();
	}

    public void flap()
    {
        anim.SetBool("isFlap", isFlapping);
        isFlapping = !isFlapping;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown && transform.position.y < 4.5 && !isDead)
        {
            rb2d.velocity = new Vector2(0, upForce);
			audio.clip = flapSound;
			audio.Play ();
            anim.SetTrigger("Flap");
        }

        rb2d.velocity = new Vector2(0, rb2d.velocity.y);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
		audio.clip = deathSound;
		audio.Play ();
        shake.PlayShake();
    }
}
