using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEventually : MonoBehaviour {

	public float waitTime = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine (Destroyy ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Destroyy(){
		yield return new WaitForSeconds (waitTime);

		Destroy (gameObject);
	}
}
