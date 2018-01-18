using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulaController : MonoBehaviour {

	Rigidbody rg;

	public float velocity = 1.5f;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody> ();

		rg.velocity = Vector3.up * -1 * velocity;

		//El giro es un tipo de movimiento
		//transform.rotate

		//rg.angularVelocity = new Vector3 (0, 360, 0);
	
		//rg.AddTorque(new Vector3(0,360,0));
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (Time.deltaTime);

		//transform.Rotate(new Vector3(0, 360*Time.deltaTime,0), Space.World);	
	}
}
