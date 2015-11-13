using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float coefficient;   // 空気抵抗係数
	public float speed;         // 爆風の速さ
	public float timer;
	public bool isBom;

	void Start(){
		isBom = false;
		if(bomManager.i == 0 || bomManager.i == 3){
			speed = 30;
		}
		if(bomManager.i == 1 || bomManager.i == 4){
			speed = 35;
		}
		if(bomManager.i == 2 || bomManager.i == 5){
			speed = 50;
		}
	}

	void Update(){
		if(isBom == true){
			timer += Time.deltaTime;
		}
	}

	void OnTriggerStay(Collider col) {
		isBom = true;
		// 風速計算
		if(timer < 0.5f){
			var velocity = (col.transform.position - transform.position).normalized * speed * speed;
			
			// 風力与える
			col.GetComponent<Rigidbody>().AddForce(velocity);
		}
	}
}