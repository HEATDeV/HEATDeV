using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class storyManager : MonoBehaviour {
	public GUIStyle style;
	private Texture2D texture;
	static public float alpha;
	private float sw;
	private float sh;
	static public bool isStart;

	void Awake (){
		texture = new Texture2D(1, 1);
		sw = Screen.width;
		sh = Screen.height;
		alpha = 1.05f;
		isStart = false;
		GameObject.Find("ui_nowloading").GetComponent<Image>().color = new Color(1,1,1,0);
	}
	
	void Update(){
		if(alpha > 0 && isStart == false){
			alpha -= Time.deltaTime;
		}
		if(isStart == true){
			alpha += Time.deltaTime * 1;
			if(alpha >= 1.1){
				GameObject.Find("ui_nowloading").GetComponent<Image>().color = new Color(1,1,1,1);
				if(alpha > 1.2){
					if(Application.loadedLevelName == "ending"){
						Application.LoadLevel("Title");
					}else{
						Application.LoadLevel("mainStage");
					}
				}
			}
		}
	}
}
