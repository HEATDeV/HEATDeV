using UnityEngine;
using System.Collections;

public class bomSystem_middle : MonoBehaviour {
	static public GameObject me;
	
	void Start(){
		//me = gameObject;
		gameObject.transform.parent = GameObject.Find("putBomSet").transform;
	}
}
