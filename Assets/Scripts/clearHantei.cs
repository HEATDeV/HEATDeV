using UnityEngine;
using System.Collections;

public class clearHantei : MonoBehaviour {
	int num;
	float timer;
    static public float deadTimer;
    static public GameObject colOb;
	// Use this for initialization
	void Start () {
		num = 0;
		timer = 0;
		deadTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (num <= 0) {
			timer += Time.deltaTime;
		} else {
			timer = 0;
		}
		if(timer > 5f){
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
        if (col.gameObject.tag == "stage" && bomManager.isBomber == true){
            colOb = col.gameObject;
		}
    }

	void OnTriggerExit(Collider col) {
		if(col.gameObject && col.gameObject.tag == "stage"){
			num--;
		}
	}

}
