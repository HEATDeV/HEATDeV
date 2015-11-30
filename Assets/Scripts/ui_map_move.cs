using UnityEngine;
using System.Collections;

public class ui_map_move : MonoBehaviour {
	Vector3 clickPosition_start;
	Vector3 clickPosition;
	public int speed;
	void Start(){
		//meVec = this.transform;
	}

	void Update () {
		//クリック処理
		if(Input.GetMouseButtonDown(0)){
			clickPosition_start = Input.mousePosition;
		}
		//移動
		if(Input.GetMouseButton(0)){
			clickPosition = Input.mousePosition;
			if(clickPosition.x + 20 < clickPosition_start.x){
				if(this.transform.position.x >= -100){
					transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
				}
			}else if(clickPosition.x > clickPosition_start.x + 20){
				if(this.transform.position.x <= 1200){
					transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
				}
			}
		}
		if (Input.GetMouseButtonUp(0)) {
			clickPosition.x = 0;
			clickPosition_start.x = 0;
		}
	}
}
