using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectManager : MonoBehaviour {
	bool isStart;
	bool isStage1;
	bool isStage2;
	bool isStage3;
	bool isStage4;
	bool isStage5;
	bool isStage6;
	bool isStage7;
	bool isStage8;
	bool isStage9;
	bool isStage10;
	bool isStage11;
	bool isStage12;
	bool isStage13;
	bool isStage14;
	bool isStage15;
	bool isStage16;
	bool isStage17;
	bool isStage18;
	bool isStage19;
	bool isStage20;
	public GUIStyle style;
	private Texture2D texture;
	private float alpha;
	public AudioClip clickSE;
	private float sw;
	private float sh;
	int systemCount;

	void Awake (){
		texture = new Texture2D(1, 1);
		sw = Screen.width;
		sh = Screen.height;
		alpha = 1.05f;
		isStart = false;
		isStage1 = true;
		isStage2 = false;
		isStage3 = false;
		isStage4 = false;
		isStage5 = false;
		isStage6 = false;
		isStage7 = false;
		isStage8 = false;
		isStage9 = false;
		isStage10 = false;
		isStage11 = false;
		isStage12 = false;
		isStage13 = false;
		isStage14 = false;
		isStage15 = false;
		isStage16 = false;
		isStage17 = false;
		isStage18 = false;
		isStage19 = false;
		isStage20 = false;
		system.stageNum = 0;
	}
	
	void Update(){
		if(GameObject.FindGameObjectsWithTag("system").Length > 1){
			Destroy(GameObject.Find ("System"));
		}
		if(isStart == false && alpha > 0){
			alpha -= Time.deltaTime;
		}
		if (isStage1 == true) {
			GameObject.Find ("heishi1").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi2").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage2 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage3 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage4 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage5 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
		}
	}

	public void stage1(){
		if (ui_map_move.isMove == false && isStage1 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = true;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage2(){
		if (ui_map_move.isMove == false && isStage2 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = true;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage3(){
		if (ui_map_move.isMove == false && isStage3 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = true;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage4(){
		if (ui_map_move.isMove == false && isStage4 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = true;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage5(){
		if (ui_map_move.isMove == false && isStage5 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = true;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage6(){
		if (ui_map_move.isMove == false && isStage6 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = true;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage7(){
		if (ui_map_move.isMove == false && isStage7 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = true;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage8(){
		if (ui_map_move.isMove == false && isStage8 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = true;
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage9(){
		if (ui_map_move.isMove == false && isStage9 == true) {
			if (!isStart) {
				this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			}
			isStart = true;
		} else {
			this.GetComponent<AudioSource> ().PlayOneShot (clickSE);
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = true;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
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
