using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class bomberSystem : MonoBehaviour {
	public bool isBomber = false;
	float bomberTime = 0;

	void Update(){
		if(isBomber == true){
			bomberTime += Time.deltaTime;
		}
		if(GameObject.Find("gameSystem").GetComponent<bomSetSystem>().bomLimit > 0 && bomberTime > 0.5f){
			isBomber = false;
			bomberTime = 0;
		}
	}

	public void bomber(){
		isBomber = true;
	}
}
