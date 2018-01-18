using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padController : MonoBehaviour {
	public float velocidad = 8;

	public float moveQuantity;

	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//Actualizar mecanicas de juego
		movePad(moveQuantity);

	}

	public void movePad(float move){
		rb.velocity = Vector3.right * move * velocidad;
	}


	public void launchBall() {

		//Si la pala tiene hijos y son "pelotas", las desenparenta y las inicia (velocidad)
		for (int i = 0; i < transform.childCount; i++)
		{
			if (transform.GetChild (i).tag == "PELOTA") {

				Transform ball = transform.GetChild (i);
				ball.transform.parent = null;

				ball.GetComponent<Rigidbody> ().isKinematic = false;
			}
		}

	}
}
