using UnityEngine;
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
		Debug.Log("isMove = " + isMove + "\n" + "touchPos_delx = " + touchPos_delt.x);
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
            
            if (3 < frame)
            {
				touchPos_delt = touchPos_ed - touchPos_now;
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
