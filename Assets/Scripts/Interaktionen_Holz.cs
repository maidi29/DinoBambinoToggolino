﻿using UnityEngine;
using System.Collections;

public class Interaktionen_Holz : MonoBehaviour {
	/*public ParticleSystem feuer;
	public ParticleSystem rauch;
	public GameObject inventoryGO;
	GameObject feuerzeug;
	private Inventory inventoryScript;
	public ItemDatabase database;
	float dist;
	GameObject target;

	// Use this for initialization
	void Start () {
		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
		inventoryScript = inventoryGO.GetComponent<Inventory> ();
		feuerzeug = GameObject.Find ("Feuerzeug");
		feuer.enableEmission = false;
		rauch.enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] items = GameObject.FindGameObjectsWithTag ("Item");
		foreach(GameObject target in items) {
			if(target.activeInHierarchy) {
				dist = Vector3.Distance(target.transform.position, transform.position);
				print (dist);
			}
		}
		if (dist <= 1.5) {
		 	for(int j = 0; j < database.items.Count; j++){
				if (database.items[j].itemID == 2 && database.items[j].itemHeat >= 800 && gameObject.activeInHierarchy ) {
					if(feuerzeug.activeInHierarchy) {
						feuer.enableEmission = true;
						rauch.enableEmission = true;
						database.items[1].itemHeat = 800;
					}
				}
			}
		}
	}*/

	/*void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Feuerzeug") {
			Debug.Log("Angezündet");
			//if (inventoryScript.holz.activeInHierarchy) {
				feuer.enableEmission = true;
				rauch.enableEmission = true;
			//}
		}
	}*/
}