﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private Vector3 deltMouse;
	private Vector3 nowMouse;
	private Vector3 edMouse;
    int num;
	private int frame;
	private bool isDrag;
	private bool isStart;
	private bool isSetBom;
	public float xspeed = 100f;
	private float sx;
	private float dx;
	private float tx;
	static public int colNum;
	public AudioClip selectSE;

	void Awake(){
		colNum = 0;
        num = 0;
		isStart = false;
		isDrag = false;
		isSetBom = false;
		if (Application.platform == RuntimePlatform.Android) {
//			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else if (Application.platform == RuntimePlatform.IPhonePlayer) {
//			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else if (Application.platform == RuntimePlatform.WindowsPlayer) {
//			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
        num = system.stageNum;
		Instantiate(Resources.Load("prefab/stage/stage" + num));
	}

	void Start (){

	}

	void Update () {
		if(!isStart){
			if(num == 1){
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if(num == 2){
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
			}
			if(num == 3){
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if(num == 4){
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if(num == 5){
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				
			}
			if(num == 6){
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if(num == 7){
				Instantiate(Resources.Load("prefab/bom/bom2"));
			}
			if(num == 8){
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if(num == 9){
				Instantiate(Resources.Load("prefab/bom/bom2"));
			}
			if(num == 10){
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if (num == 11)
			{
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if (num == 12)
			{
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
			}
			
			if (num == 13)
			{				
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if (num == 14)
			{
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if (num == 15)
			{
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			if (num == 16)
			{
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
			}
			if (num == 17){
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
			}
			if (num == 18){
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
			}
			if (num == 19){
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
			}
			if (num == 20){
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom2"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom5"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
				Instantiate(Resources.Load("prefab/bom/bom1"));
			}
			isStart = true;
//			GameObject.Find ("Canvas").GetComponent<Canvas> ().renderMode = RenderMode.ScreenSpaceCamera;
		}

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

	public void Pause(){
		GetComponent<AudioSource> ().PlayOneShot (selectSE);
		GameObject.Find ("ui_pause").GetComponent<Image> ().raycastTarget = true;
		GameObject.Find ("ui_pause").GetComponent<Image>().color = new Color(1, 1, 1, 1);
		GameObject.Find ("ui_yes").GetComponent<Image> ().raycastTarget = true;
		GameObject.Find ("ui_yes").GetComponent<Image>().color = new Color(1, 1, 1, 1);
		GameObject.Find ("ui_no").GetComponent<Image> ().raycastTarget = true;
		GameObject.Find ("ui_no").GetComponent<Image>().color = new Color(1, 1, 1, 1);
		Time.timeScale = 0;
	}

	public void yes(){
		GetComponent<AudioSource> ().PlayOneShot (selectSE);
		Application.LoadLevel ("Select");
		Time.timeScale = 1;
		clearHantei.deadTimer = 0;
	}

	public void no(){
		GetComponent<AudioSource> ().PlayOneShot (selectSE);
		GameObject.Find ("ui_pause").GetComponent<Image> ().raycastTarget = false;
		GameObject.Find ("ui_pause").GetComponent<Image>().color = new Color(1, 1, 1, 0);
		GameObject.Find ("ui_yes").GetComponent<Image> ().raycastTarget = false;
		GameObject.Find ("ui_yes").GetComponent<Image>().color = new Color(1, 1, 1, 0);
		GameObject.Find ("ui_no").GetComponent<Image> ().raycastTarget = false;
		GameObject.Find ("ui_no").GetComponent<Image>().color = new Color(1, 1, 1, 0);
		Time.timeScale = 1;
	}
}
