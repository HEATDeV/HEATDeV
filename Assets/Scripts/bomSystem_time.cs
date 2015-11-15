using UnityEngine;
using System.Collections;

public class bomSystem_time : MonoBehaviour {
	static public GameObject me;
	public float timer;
	void Start(){
		me = this.gameObject;
	}
	
	void Update () {
		if (bomManager.isBomber == true) {
			timer -= Time.deltaTime;
			if(timer < 0){
				bomManager.timeBom();
			}
		}
	}
}
