using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider Player) {
		if (Player.gameObject.tag == "Player") {
			Application.LoadLevel("Main");
		}
	}


	void OnCollisonEnter(Collision Player)
	{
		Debug.Log (Player);
		if (Player.gameObject.tag == "Player") {
			Application.LoadLevel ("Main");
		}
	}

}
