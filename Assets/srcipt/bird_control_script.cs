﻿using UnityEngine;
using System.Collections;

public class bird_control_script : MonoBehaviour {

	public float maxSpeed = 5f;
	public bool movingRight = false;
	public bool movingLeft = false;
	public bool movingUp = false;
	public bool movingDown = false;
	public bool move = false;
	public bool changetime = true;
	int time = 0;
	//int timeTrack = 0;
	
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	void Update()
	{   /// track the position of bird while it is alive


		/// change time
		/// 
		/// 
		if (Input.GetKey (KeyCode.Q)) {
			///time
			if(changetime){	
				if(time < 200)
				{
					transform.Translate(20f,0,0);
					time += 100;
				}
				else{
					time = 0;
					transform.Translate(-40f,0,0);
					
				}
				

				anim.SetBool ("movingRight", false);
				anim.SetBool ("movingLeft", false);
				anim.SetBool ("movingUp", false);
				anim.SetBool ("movingDown", false);
			}
			changetime = false;
			
		}
		
		
		
		if (Input.anyKey == false) {
			changetime = true;

		}
		

	}
	
	void FixedUpdate () {
		move = false;
		
		float movex = Input.GetAxis ("Horizontal");
		//Debug.Log (movex);
		float movey = Input.GetAxis ("Vertical");
		//Debug.Log (movey);
		anim.SetBool("movingRight",false);
		anim.SetBool("movingLeft",false);
		anim.SetBool("movingUp",false);
		anim.SetBool("movingDown",false);
		rigidbody2D.velocity = new Vector2 (0,0);
		
		Debug.Log ("xx= "+ transform.position.x);
		Debug.Log ("y= "+ transform.position.x);

		if (Mathf.Abs (movex) > 0.1 || Mathf.Abs (movey) > 0.1 ) {
				//if(Mathf.Abs (movex) < 0.862)
				move = true;
				anim.SetBool ("move", true);
				anim.SetBool ("movingRight", false);
				anim.SetBool ("movingLeft", false);
				anim.SetBool ("movingUp", false);
				anim.SetBool ("movingDown", false);
				
			} else {
				move = false;
				anim.SetBool ("move", false);
			}

			
			if (move == true) {
				if (Mathf.Abs (movex) > 0.1) {
					if (movex > 0) {
						anim.SetBool ("movingRight", true);
						anim.SetBool ("movingLeft", false);
						anim.SetBool ("movingUp", false);
						anim.SetBool ("movingDown", false);
						
						
					} else {
						anim.SetBool ("movingLeft", true);
						anim.SetBool ("movingRight", false);
						anim.SetBool ("movingUp", false);
						anim.SetBool ("movingDown", false);
					}
					rigidbody2D.velocity = new Vector2 (movex * maxSpeed, rigidbody2D.velocity.y);
				//rigidbody2D.AddForce( new Vector2 (100f, 0));
				} else {
					
					if (Mathf.Abs (movey) > 0.1) {
						if (movey > 0) {
							anim.SetBool ("movingUp", true);
							anim.SetBool ("movingLeft", false);
							anim.SetBool ("movingRight", false);
							anim.SetBool ("movingDown", false);
						} else {
							anim.SetBool ("movingDown", true);
							anim.SetBool ("movingLeft", false);
							anim.SetBool ("movingUp", false);
							anim.SetBool ("movingRight", false);
						}
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, movey * maxSpeed);
						//		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 8.62f);
					}
					
				}
				
			}
			
			
		
		
		
		
	}
	
}