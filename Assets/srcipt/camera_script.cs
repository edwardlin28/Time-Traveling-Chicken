using UnityEngine;
using System.Collections;

public class camera_script : MonoBehaviour {
	public bool changetime = true;
	int time  = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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
				

			}
			changetime = false;
			
		}
		
		
		
		if (Input.anyKey == false) {
			changetime = true;
			
		}

	
	}
}
