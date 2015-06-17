using UnityEngine;
using System.Collections;

public class rock_script : MonoBehaviour {
	public GameObject parentRock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(parentRock.transform.position.x+20,parentRock.transform.position.y,parentRock.transform.position.z);
	
	}
}
