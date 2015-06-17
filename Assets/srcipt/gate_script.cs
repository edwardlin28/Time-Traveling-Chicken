using UnityEngine;
using System.Collections;

public class gate_script : MonoBehaviour {
	public GameObject player ;
	bird_control_new bird_script;

	// Use this for initialization
	void Start () {
		bird_script = (bird_control_new)player.GetComponent<bird_control_new> (); 

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			if(bird_script.carrykey >0)
			{
				bird_script.carrykey--;
				Destroy(gameObject);
			}
			}

		
	}
}
