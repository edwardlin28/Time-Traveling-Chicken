using UnityEngine;
using System.Collections;

public class predator_moving : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetBool("moving_left",true);
		anim.SetBool("moving_right",false);

		rigidbody2D.velocity = new Vector2 (-3f, rigidbody2D.velocity.y);



	
	}

	void Update()

	{
		//Debug.Log (transform.position.x);

		if (transform.position.x < 40f) {
			rigidbody2D.velocity = new Vector2 (1f, rigidbody2D.velocity.y);
			anim.SetBool ("moving_left", false);
			anim.SetBool ("moving_right", true);
			
			
		} 
			if (transform.position.x > 45f) {
						rigidbody2D.velocity = new Vector2 (-1f, rigidbody2D.velocity.y);
						anim.SetBool ("moving_left", true);
						anim.SetBool ("moving_right", false);

				}

		}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			//Destroy (other.gameObject);
			Application.LoadLevel (Application.loadedLevelName);
		
		
		
	}

}
