using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {
	public GameObject prefab_bola;

	public GameObject bola;
	public Transform pala;

	// Use this for initialization
	void Start () {
		Debug.Log ("Iniciando nivel");
		RespawnBall ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//1.Estabelce la pala y la bola
	//2.Hace hija la bola de la pala
	//....
	public void RespawnBall(){
		//GamObject.Find ("nombreObjeto") <<-- Encuentra objeto por nombre

		bola = GameObject.FindGameObjectWithTag ("PELOTA"); // <<--- Encuentra un objeto por Tag

		Debug.Log("respawnBall");

		//Instanciacion
		if (!bola) {
			bola = GameObject.Instantiate (prefab_bola);
		}

		//pala = GameObject.FindGameObjectWithTag ("PALA").transform;

		pala = GameObject.FindObjectOfType<padController> ().gameObject.transform; //<-- Encuentra un componente (script)

		//bola.transform.parent = pala;
		//bola.transform.localPosition = new Vector3 (0, 0.75f, 0); 

		bola.transform.SetParent (pala, true);
		bola.transform.localPosition = new Vector3 (0, 0.75f, 0); 
	}
}
