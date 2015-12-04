using UnityEngine;
using System.Collections;

public class selectManager : MonoBehaviour {
	bool isStart;
	public GUIStyle style;
	private Texture2D texture;
	public float alpha;
	public AudioClip clickSE;
	private float sw;
	private float sh;
	
	void Awake (){
		texture = new Texture2D(1, 1);
		sw = Screen.width;
		sh = Screen.height;
		alpha = 1.05f;
		isStart = false;
	}
	
	void Update(){
		if(isStart == false && alpha > 0){
			alpha -= Time.deltaTime;
		}
	}

	public void stage1(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage2(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage3(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage4(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage5(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage6(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage7(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage8(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}
	public void stage9(){
		if(ui_map_move.isMove == false)
			if(!isStart){
				this.GetComponent<AudioSource>().PlayOneShot(clickSE);
			}
			isStart = true;
	}

	void OnGUI(){
		texture.SetPixel(0,0,new Color(0,0,0,alpha));
		texture.Apply();
		GUI.DrawTexture(new Rect(0,0,sw,sh), texture);		
		if(isStart == true){
			texture.SetPixel(0,0,new Color(0,0,0,alpha));
			texture.Apply();
			GUI.DrawTexture(new Rect(0,0,sw,sh), texture);
			alpha += Time.deltaTime * 1;
			if(alpha > 1.5){
				Application.LoadLevel("Story");
			}
		}
	}
}
