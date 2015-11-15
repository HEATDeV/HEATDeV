using UnityEngine;
using System.Collections;

public class bomSystem_side : MonoBehaviour {
	static public GameObject me;
	
	void Start(){
		me = this.gameObject;
	}
	
	void Update () {
		if (bomManager.isBomber == true) {
			bomManager.sideBom();
		}
	}
}
