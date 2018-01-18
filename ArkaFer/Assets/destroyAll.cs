using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){

		GameObject.Destroy (other.gameObject);

		GameObject.Find ("LevelManager").SendMessage ("RespawnBola",
			SendMessageOptions.DontRequireReceiver);
	}
}
