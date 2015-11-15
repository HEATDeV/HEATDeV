using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float coefficient;   // 空気抵抗係数
	public float speed;         // 爆風の速さ
	public float timer;
	public bool isBom;

	void Start(){
		isBom = false;
	}

	void Update(){
		if(this.gameObject.name == "bakuhatu_small(Clone)"){
			speed = 30;
		}
		if(this.gameObject.name == "bakuhatu_middle(Clone)" || this.gameObject.name == "bakuhatu_time(Clone)"){
			speed = 35;
		}
		if(this.gameObject.name == "bakuhatu_big(Clone)"){
			speed = 50;
		}
		if(this.gameObject.name == "bakuhatu_side(Clone)" || this.gameObject.name == "bakuhatu_upper(Clone)"){
			speed = 25;
		}
		if(isBom == true){
			timer += Time.deltaTime;
		}
	}

	void OnTriggerStay(Collider col) {
		isBom = true;
		// 風速計算
		var velocity = new Vector3(0,0,0).normalized;
		if(col.gameObject.tag == "stage"){
			if(timer < 0.5f){
				if(this.gameObject.name == "bakuhatu_small(Clone)"){
					velocity = (col.transform.position - transform.position).normalized * speed * speed;			
					// 風力与える
				}
				if(this.gameObject.name == "bakuhatu_middle(Clone)"){
					velocity = (col.transform.position - transform.position).normalized * speed * speed;			
					// 風力与える
				}
				if(this.gameObject.name == "bakuhatu_big(Clone)"){
					velocity = (col.transform.position - transform.position).normalized * speed * speed;			
					// 風力与える
				}
				if(this.gameObject.name == "bakuhatu_upper(Clone)"){
					velocity = new Vector3(0,col.transform.position.y - transform.position.y,0).normalized * speed * speed * speed;			
					// 風力与える
				}
				if(this.gameObject.name == "bakuhatu_side(Clone)"){
					velocity = new Vector3(col.transform.position.x - transform.position.x,0,col.transform.position.z - transform.position.z).normalized * speed * speed * speed;			
					// 風力与える
				}
				if(this.gameObject.name == "bakuhatu_time(Clone)"){
					velocity = (col.transform.position - transform.position).normalized * speed * speed;			
					// 風力与える
				}
				col.GetComponent<Rigidbody>().AddForce(velocity);
			}
		}
	}
}