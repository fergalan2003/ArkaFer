using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladrilloController : MonoBehaviour {
	public int hits = 1;

	void hit(){
		hits --;

		if (hits <= 0)
			death ();
	}

	void death(){
		Destroy (this.gameObject);
	}
}
