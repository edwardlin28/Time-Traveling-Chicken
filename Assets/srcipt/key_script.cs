using UnityEngine;
using System.Collections;

public class key_script : MonoBehaviour {
	public GameObject player;
	bird_control_new bird_script;


	// Use this for initialization
	void Start () {
		bird_script = (bird_control_new)player.GetComponent<bird_control_new> (); 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
						bird_script.carrykey ++;
						Destroy (gameObject);
				}
		
	}
}
