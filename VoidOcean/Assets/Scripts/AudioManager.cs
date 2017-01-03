using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;

	public Sound[] sounds;

	void Start () {
		instance = this;

		foreach (Sound s in sounds) {
			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;
		}


	}
	
	public void Play(string sound)
	{
		Sound s = Array.Find (sounds, item => item.name == sound);

		s.source.Play ();
	}
}
