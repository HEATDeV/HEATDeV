using UnityEngine;
using System.Collections;

public class bomName : MonoBehaviour {
	static public string name = "null";
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void pushIcon(){
		name = transform.name;
	}
}
