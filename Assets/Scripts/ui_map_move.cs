﻿using UnityEngine;
using System.Collections;

public class ui_map_move : MonoBehaviour {
    /*
	Vector3 clickPosition_start;
	Vector3 clickPosition;
	public int speed;
    */
    /*
    private Vector3 screenPoint;
    private Vector3 offset;
    */

    private float sw;
    private float sh;
    private Vector3 touchPos_now;
    private Vector3 touchPos_ed;
    static public Vector3 touchPos_delt;
    bool isDrag;
    int frame;
	static public bool isMove = false;
	float timer;

	void Start(){
        sw = Screen.width;
        sh = Screen.height;
		isMove = false;
        frame = 0;
		timer = 0;
        touchPos_now = Vector3.zero;
        touchPos_ed = Vector3.zero;
        touchPos_delt = Vector3.zero;
		if(system.stageNum >= 1 && system.stageNum <= 6){
			this.transform.position = new Vector3(sw + sw / 2.3f, this.transform.position.y, this.transform.position.z);
		}
		if(system.stageNum >= 7 && system.stageNum <= 9){
			this.transform.position = new Vector3(sw - sw / 5.5f, this.transform.position.y, this.transform.position.z);
		}
		if(system.stageNum >= 10 && system.stageNum <= 14){
			this.transform.position = new Vector3(sw - sw / 1.35f, this.transform.position.y, this.transform.position.z);
		}
		if(system.stageNum >= 15 && system.stageNum <= 20){
			this.transform.position = new Vector3(-sw / 2.3f, this.transform.position.y, this.transform.position.z);
		}
	}

	void Update () {
		if (touchPos_delt.x > -10f && touchPos_delt.x < 10f) {
		} else {
			isMove = true;
		}
		if (isMove && !isDrag) {
			timer += Time.deltaTime;
		}
		if (timer > 0.1f) {
			isMove = false;
			timer = 0;
		}
        touchManager();


        /*千葉あがき
		//クリック処理
		if(Input.GetMouseButtonDown(0)){
            // バーの位置をメインカメラから見た時の座標に変換して取得
            this.screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
            // バーの中心位置からタップ位置の差(offset)を取得
            this.offset = this.transform.position
               - Camera.main.ScreenToWorldPoint(
                 new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z));
			clickPosition_start = Input.mousePosition;
		}
		//移動
        if (Input.GetMouseButton(0))
        {
            clickPosition = Input.mousePosition;
            if (clickPosition_start.x - clickPosition.x > 20 || clickPosition_start.x - clickPosition.x < -20)
            {
                // 現在のタップ位置を取得。y軸z軸は動かさないのでバーの位置で取得
                Vector3 currentScreenPoint =
                          new Vector3(Input.mousePosition.x * speed, screenPoint.y, screenPoint.z);
                // タップ位置+offsetを取得
                Vector3 currentPosition =
                          Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
                // バーの位置を更新
                this.transform.position = currentPosition;
            }
        }
         * */
    }


    void touchManager()
    {




        if (isDrag)
        {
            touchPos_ed = touchPos_now;
            touchPos_now = Input.mousePosition;
            
            if (1 < frame)
            {
				touchPos_delt = touchPos_ed - touchPos_now;
				if(this.transform.position.x < -sw / 2.3f){
		//			this.transform.position = new Vector3(-sw / 2.3f, this.transform.position.y, this.transform.position.z);
					if(touchPos_delt.x > 0)
						touchPos_delt.x = 0;
				}
				if(this.transform.position.x > sw + sw / 2.3f){
		//			this.transform.position = new Vector3(sw + sw / 2.3f, this.transform.position.y, this.transform.position.z);
					if(touchPos_delt.x < 0)
						touchPos_delt.x = 0;
				}
				if(touchPos_delt.x > 20){
					touchPos_delt.x = 20;
				}else if(touchPos_delt.x < -20){
					touchPos_delt.x = -20;
				}
                transform.Translate(Vector3.left * sw * 0.003f * touchPos_delt.x, Space.World);
            }
            frame++;
            
        }else{
            frame = 0;
            touchPos_now = Vector3.zero;
            touchPos_ed = Vector3.zero;
            touchPos_delt = Vector3.zero;
        }
        if (Input.GetMouseButtonDown(0))
        {
            isDrag = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDrag = false;
        }


    }
}
