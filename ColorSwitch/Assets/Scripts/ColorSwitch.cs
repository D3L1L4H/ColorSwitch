﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// on trigger
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			GamePlayController.instance.ColorSwitcher ();
			GamePlayController.instance.playcolorSwitchSound ();
			gameObject.SetActive (false);
		}
	}
}
