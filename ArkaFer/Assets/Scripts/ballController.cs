using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour {

	public Vector3 direccion;
	public float velocidad;

	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = direccion.normalized * velocidad;
	}

	void OnCollisionEnter(Collision other){

		switch (other.collider.tag) {
			case "PARED":
				direccion.x *= -1;
				break;
			
			case "TECHO":
				direccion.y *= -1;
				break;
			
			case "PALA":
				direccion.y *= -1;
				break;
		case "LADRILLO":
			Vector3 relativeHit = other.contacts [0].point - other.gameObject.transform.position;

			if (Mathf.Abs (relativeHit.x) == other.transform.localScale.x / 2)
				direccion.x *= -1;
			if (Mathf.Abs (relativeHit.y) == other.transform.localScale.y / 2)
				direccion.y *= -1;

			other.gameObject.SendMessage ("hit");
			//other.contacts[0].point
			//other.gameObject.transform.position
			break;

			case "ENEMIGO":

				break;
			default:

				break;

		}
	}
}
