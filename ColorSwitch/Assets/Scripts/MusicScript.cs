﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {
	static MusicScript instance = null;
	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		//void.call();
	}
}
