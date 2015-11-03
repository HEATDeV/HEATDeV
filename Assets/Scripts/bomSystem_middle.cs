using UnityEngine;
using System.Collections;

public class bomSystem_middle : MonoBehaviour {
	GameObject bomber;
	GameObject bakuhu;
	GameObject bS;
	// Use this for initialization
	void Start () {
		bS = GameObject.Find ("gameSystem");
	}
	
	// Update is called once per frame
	void Update () {
		if (bS.GetComponent<bomberSystem>().isBomber == true) {
			bakuhu = Instantiate (
				Resources.Load ("prefab/bakuhatu_middle"),
				this.transform.position,
				Quaternion.identity)as GameObject;
				Destroy(this.gameObject);
		}
	}
}
