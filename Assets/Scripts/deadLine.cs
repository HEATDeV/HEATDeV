using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deadLine : MonoBehaviour {
	public GUIStyle style;
	public GUISkin clearSkin;
	bool isClear;
	float sw;
	float sh;
	float swX;
	int speed = 0;
	private Slider slider;
	float sliVal;
	int stageCount;
	// Use this for initialization
	void Start () {
		sw = Screen.width;
		sh = Screen.height;
		swX = sw * 2;
		slider = GameObject.Find("stageSlider").GetComponent<Slider>();
		stageCount = GameObject.FindGameObjectsWithTag("stage").Length - 1;
		slider.maxValue = stageCount;
		sliVal = stageCount;
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			speed = 100;
		} else if (Application.platform == RuntimePlatform.IPhonePlayer) {
			speed = 100;
		}else {
			speed = 25;
		}
		if(swX > -3000 && isClear == true){
			if(swX > 1.9f * sw / 5){
				swX -= Time.deltaTime * 1000;
			}else{
				swX -= Time.deltaTime * speed;
			}
			if(swX < 1.5f * sw / 5){
				swX -= Time.deltaTime * 1000;	
			}
		}

		stageCount = GameObject.FindGameObjectsWithTag("stage").Length - 1;
		if(sliVal > stageCount){
			sliVal -= 0.5f;
		}
		slider.value = sliVal;
		if(sliVal <= 0){
			isClear = true;
		}
	}
	void OnCollisionStay(Collision collision){
		Destroy (collision.gameObject);
	}

	void OnGUI(){
		GUI.skin = clearSkin;
		GUI.Box(new Rect(swX, 1.5f * sh /  7f, 3f * sw / 5f, 1.5f * sh / 7f),"");		
	}
}
