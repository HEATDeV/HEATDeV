using UnityEngine;
using System.Collections;

public class nonCol : MonoBehaviour {
    static public bool isDamage;
    static public GameObject colMe;
    void Start() {
        isDamage = false;
    }
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "stage" && this.gameObject.tag != "deadOb_house" || collision.gameObject.tag == "deadOb" && this.gameObject.tag != "deadOb_house"){
			nonCol.colMe = this.gameObject;
			isDamage = true;
		}
	}
	void OnCollisionStay(Collision collision)
	{
		if(collision.gameObject.tag == "stage" && this.gameObject.tag != "deadOb_house" || collision.gameObject.tag == "deadOb" && this.gameObject.tag != "deadOb_house"){
			nonCol.colMe = this.gameObject;
			isDamage = true;
		}
	}
}
