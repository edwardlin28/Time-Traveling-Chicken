using UnityEngine;
using System.Collections;

public class fire_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			
			Application.LoadLevel (Application.loadedLevelName);

		if (other.gameObject.tag == "rock")
						Destroy (gameObject);


	}
}
