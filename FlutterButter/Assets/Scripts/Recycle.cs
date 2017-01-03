using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour {

    public bool isPillar = false;

    private Rigidbody2D rb2d;
   	private BoxCollider2D box;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
	}
	
	void Update () {
	    if (rb2d.position.x < -18)
        {

            float y = 0;

            if(isPillar)
            {
                y = Random.Range(-2f, 1f);
                transform.position = new Vector3(18, y, 0);
            }
            else
                transform.position = new Vector3(18, transform.position.y, 0);
            // rb2d.position.Set(12, 0);// = new Vector3(,0,0);

        }

        //Debug.Log(rb2d.position.x);
	}
}
