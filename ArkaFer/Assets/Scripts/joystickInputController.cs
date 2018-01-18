using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(padController))]
public class joystickInputController : MonoBehaviour {


	padController pad;

	// Use this for initialization
	void Start () {
		pad = GetComponent<padController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Recoger todos los inputs
		if (Input.GetAxisRaw ("Horizontal") != 0) {			

			pad.moveQuantity = Input.GetAxis ("Horizontal");

		} else {

			pad.moveQuantity = 0;
		}
	}
}
