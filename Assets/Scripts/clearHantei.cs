using UnityEngine;
using System.Collections;

public class clearHantei : MonoBehaviour {
	int num = 0;
	float timer = 0;
    static public float deadTimer = 0;
    static public GameObject colOb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (num <= 0) {
			timer += Time.deltaTime;
		} else {
			timer = 0;
		}
		if(timer > 3f){
			deadLine.isClear= true;
		}
        if(num > 0 && bomManager.isBomber == true){
            deadTimer += Time.deltaTime;
        }
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject && col.gameObject.tag == "stage"){
			num++;
		}
	}

    void OnTriggerStay(Collider col) {
        if (col.gameObject && col.gameObject.tag == "stage" && bomManager.isBomber == true){
            colOb = col.gameObject;
        }
    }

	void OnTriggerExit(Collider col) {
		if(col.gameObject && col.gameObject.tag == "stage"){
			num--;
		}
	}

}
