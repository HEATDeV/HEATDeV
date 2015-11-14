using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private Vector3 deltMouse;
	private Vector3 nowMouse;
	private Vector3 edMouse;
	private int frame;
	private bool isDrag;
	private bool isSetBom;
	public float xspeed = 100f;
	private float sx;
	private float dx;
	private float tx;

	void Awake(){
		isDrag = false;
		isSetBom = false;
		if (Application.platform == RuntimePlatform.Android) {
			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else if (Application.platform == RuntimePlatform.IPhonePlayer) {
			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else if (Application.platform == RuntimePlatform.WindowsPlayer) {
			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(1)) {
			sx = Input.mousePosition.x;
		}
		if(Input.GetMouseButton(1)) {
			dx = Input.mousePosition.x;
			tx = sx - dx;
			GameObject.Find("cameraVector").transform.Rotate(0, tx / xspeed , 0);
		}		
		if (isDrag) {
			isSetBom = false;
		}
		
		if (Input.GetMouseButtonDown (0) && isDrag == false) {
			frame = 0;
			isSetBom = true;
		}
		if (Input.GetMouseButtonUp(0)){
			isDrag = false;
			
		}		
		if (Input.GetMouseButtonDown (1)) {
			isDrag = true;
			frame = 0;
		}
		if (Input.GetMouseButtonUp(1)){
			isDrag = false;
			
		}		
		frame ++;
	}

	public void Reset(){
		Application.LoadLevel (Application.loadedLevelName);
	}
}
