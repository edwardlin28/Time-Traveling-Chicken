using UnityEngine;
using System.Collections;

public class clickcript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GUI.Button(new Rect(15,15,200,200),GUIStyle.none))
		    {
			Application.LoadLevel(1);

		}
	}
}
