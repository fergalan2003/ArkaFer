using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(padController))]
public class keyBoardInputController : MonoBehaviour {

	padController pad;

	public KeyCode tecla_izq;
	public KeyCode tecla_der;
	public KeyCode tecla_lanzar;

	// Use this for initialization
	void Start () {
		pad = GetComponent<padController> ();
	}
	
	// Update is called once per frame
	void Update () {
		pad.moveQuantity = 0;

		//Recoger todos los inputs
		if (Input.GetKey(tecla_izq)) {			

			pad.moveQuantity = -1;

		} 
		if (Input.GetKey(tecla_der)) {			

			pad.moveQuantity = 1;

		} 
		if (Input.GetKey(tecla_lanzar)) {			

			pad.launchBall();

		}

	}
}
