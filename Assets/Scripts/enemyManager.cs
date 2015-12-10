using UnityEngine;
using System.Collections;

public class enemyManager : MonoBehaviour {
	static public GameObject enemyOb;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectsWithTag("enemy").Length == 0){
			enemyOb = null;
		}
		if (this.tag == "enemy") {
			enemyOb = this.gameObject;
		}
	}

	void OnCollisionStay(Collision collision) {
		if(this.tag == "enemy" && collision.gameObject.tag == "field"){
			this.tag = "dieEnemy";
		}
	}
}
