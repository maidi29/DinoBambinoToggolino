﻿using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {
	//public GameObject parentGameObject;
	public GameObject InventoryGO;
	private Index indexScript;
	private Inventory inventoryScript;
	GUIText tipp;


	// Use this for initialization
	void Start () {
		inventoryScript = InventoryGO.GetComponent<Inventory> ();
		tipp = GameObject.Find("Tipp2").guiText;
	}
	
	// Update is called once per frame
	void Update () {

	}

		void OnTriggerStay(Collider other) {
			if (other.gameObject.tag == "Item") {
				if (Input.GetKey (KeyCode.E)) {
					inventoryScript.use = false;
					other.gameObject.SetActive (false);
					other.gameObject.GetComponent<ItemBounce>().enabled = false;
					indexScript = other.gameObject.GetComponent<Index> ();
					inventoryScript.AddItem (indexScript.index);
					tipp.text = "";
					
				}
			if (other.gameObject.activeSelf) {
					tipp.text = "Drücke E um das Objekt aufzusammeln.";
				}
			}
		}
		
		void OnTriggerExit(Collider other) {
			tipp.text = "";
		}
	}
	