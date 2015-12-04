using UnityEngine;
using System.Collections;

public class storyManager : MonoBehaviour {
	public GUIStyle style;
	private Texture2D texture;
	public float alpha;
	private float sw;
	private float sh;
	
	void Awake (){
		texture = new Texture2D(1, 1);
		sw = Screen.width;
		sh = Screen.height;
		alpha = 1.05f;
	}
	
	void Update(){
		if(alpha > 0){
			alpha -= Time.deltaTime;
		}
	}
	
	void OnGUI(){
		texture.SetPixel(0,0,new Color(0,0,0,alpha));
		texture.Apply();
		GUI.DrawTexture(new Rect(0,0,sw,sh), texture);
	}
}
