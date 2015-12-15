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
			speed = 25;
		}
		if(this.gameObject.name == "bakuhatu_middle(Clone)" || this.gameObject.name == "bakuhatu_time(Clone)"){
			speed = 50;
		}
		if(this.gameObject.name == "bakuhatu_big(Clone)"){
			speed = 100;
		}
		if(this.gameObject.name == "bakuhatu_side(Clone)"){
			speed = 15f;
		}
		if(this.gameObject.name == "bakuhatu_upper(Clone)"){
			speed = 9f;
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
					col.GetComponent<Rigidbody>().AddExplosionForce(speed, transform.position, 30f, speed / 100f);
				}
				if(this.gameObject.name == "bakuhatu_middle(Clone)"){
					col.GetComponent<Rigidbody>().AddExplosionForce(speed * 10f, transform.position, 30f, speed / 100f);
				}
				if(this.gameObject.name == "bakuhatu_big(Clone)"){
					col.GetComponent<Rigidbody>().AddExplosionForce(speed * 10f, transform.position, 50f, speed / 100f);
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
					col.GetComponent<Rigidbody>().AddExplosionForce(speed * 10f, transform.position, 30f, speed / 100f);
				}
				col.GetComponent<Rigidbody>().AddForce(velocity);
			}
		}
	}
}