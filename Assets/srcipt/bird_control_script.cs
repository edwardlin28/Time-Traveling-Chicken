using UnityEngine;
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

	
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	void Update()
	{
		/// change time
		/// 
		/// 
		if (Input.GetKey (KeyCode.Q)) {
			if(changetime){	
				if(time < 100)
				{
					transform.Translate(20f,0,0);
					time += 100;
				}
				else{
					time = 0;
					transform.Translate(-20f,0,0);
					
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
			//Debug.Log ("move = " + move);
			
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
					//	rigidbody2D.velocity = new Vector2 (8.62f, rigidbody2D.velocity.y);
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