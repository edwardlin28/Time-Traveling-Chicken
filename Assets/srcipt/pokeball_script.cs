﻿using UnityEngine;
using System.Collections;

public class pokeball_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
						Application.LoadLevel (Application.loadedLevel+1);
				}

	}
}
