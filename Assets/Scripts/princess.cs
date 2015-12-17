using UnityEngine;
using System.Collections;

public class princess : MonoBehaviour {
	static public bool isPrincess;
	static public GameObject priOb;
	// Use this for initialization
	void Start () {
		isPrincess = false;
		priOb = GameObject.Find("character_princess");
	}

	void Update(){
		if (isPrincess) {
			priOb = null;
		}
	}
	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "princess"){
			isPrincess = true;
		}
		if(col.gameObject.tag == "deadPri"){
			isPrincess = true;
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "princess"){
			isPrincess = false;
		}
		if(col.gameObject.tag == "deadPri"){
			isPrincess = false;
		}
	}
}
