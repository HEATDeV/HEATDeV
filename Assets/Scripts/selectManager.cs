using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectManager : MonoBehaviour {
	bool isBegin;
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
	private float beta;
	private bool isRes;
	public AudioClip clickSE;
	private float sw;
	private float sh;
	int systemCount;

	void Awake (){
		texture = new Texture2D(1, 1);
		sw = Screen.width;
		sh = Screen.height;
		alpha = 1.05f;
		beta = 1.5f;
		isRes = false;
		isBegin = false;
		isStart = false;
		if (system.stageNum == 1) {
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
		} else if (system.stageNum == 2) {
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
		} else if (system.stageNum == 3) {
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
		} else if (system.stageNum == 4) {
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
		} else if (system.stageNum == 5) {
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
		} else if (system.stageNum == 6) {
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
		} else if (system.stageNum == 7) {
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
		} else if (system.stageNum == 8) {
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
		} else if (system.stageNum == 9) {
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
		} else if (system.stageNum == 10) {
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = true;
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
		} else if (system.stageNum == 11) {
			isStage1 = false;
			isStage2 = false;
			isStage3 = false;
			isStage4 = false;
			isStage5 = false;
			isStage6 = false;
			isStage7 = false;
			isStage8 = false;
			isStage9 = false;
			isStage10 = false;
			isStage11 = true;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 12) {
			isStage1 = false;
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
			isStage12 = true;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 13) {
			isStage1 = false;
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
			isStage13 = true;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 14) {
			isStage1 = false;
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
			isStage14 = true;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 15) {
			isStage1 = false;
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
			isStage15 = true;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 16) {
			isStage1 = false;
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
			isStage16 = true;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 17) {
			isStage1 = false;
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
			isStage17 = true;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 18) {
			isStage1 = false;
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
			isStage18 = true;
			isStage19 = false;
			isStage20 = false;
		} else if (system.stageNum == 19) {
			isStage1 = false;
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
			isStage19 = true;
			isStage20 = false;
		} else if (system.stageNum == 20) {
			isStage1 = false;
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
			isStage20 = true;
		} else {
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






		system.stageNum = 0;
	}
	
	void Update(){
		if(GameObject.FindGameObjectsWithTag("system").Length > 1){
			Destroy(GameObject.Find ("System"));
		}
		if(isStart == false && alpha > 0){
			alpha -= Time.deltaTime;
		}
		if (beta >= 0.5f && isRes == false) {
			beta -= Time.deltaTime / 2;
		} else {
			isRes = true;
		}
		if(isRes == true){
			beta += Time.deltaTime / 2;
		}
		if(beta > 1f){
			isRes = false;
		}

		if (isStage1) {
			if (system.clear1 == true) {
				GameObject.Find ("ui_stage1 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage1").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else if(!isStage1){
			if (system.clear1) {
				GameObject.Find ("ui_stage1 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage1").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage2) {
			if (system.clear2) {
				GameObject.Find ("ui_stage2 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage2").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear2) {
				GameObject.Find ("ui_stage2 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage2").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage3) {
			if (system.clear3) {
				GameObject.Find ("ui_stage3 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage3").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear3) {
				GameObject.Find ("ui_stage3 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage3").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage4) {
			if (system.clear4) {
				GameObject.Find ("ui_stage4 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage4").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear4) {
				GameObject.Find ("ui_stage4 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage4").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage5) {
			if (system.clear5) {
				GameObject.Find ("ui_stage5 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage5").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear5) {
				GameObject.Find ("ui_stage5 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage5").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage6) {
			if (system.clear6) {
				GameObject.Find ("ui_stage6 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage6").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear6) {
				GameObject.Find ("ui_stage6 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage6").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage7) {
			if (system.clear7) {
				GameObject.Find ("ui_stage7 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage7").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear7) {
				GameObject.Find ("ui_stage7 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage7").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage8) {
			if (system.clear8) {
				GameObject.Find ("ui_stage8 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage8").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear8) {
				GameObject.Find ("ui_stage8 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage8").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage9) {
			if (system.clear9) {
				GameObject.Find ("ui_stage9 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage9").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear9) {
				GameObject.Find ("ui_stage9 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage9").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage10) {
			if (system.clear10) {
				GameObject.Find ("ui_stage10 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage10").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear10) {
				GameObject.Find ("ui_stage10 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage10").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage11) {
			if (system.clear11 == true) {
				GameObject.Find ("ui_stage11 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage11").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else if(!isStage11){
			if (system.clear11) {
				GameObject.Find ("ui_stage11 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage11").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage12) {
			if (system.clear12) {
				GameObject.Find ("ui_stage12 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage12").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear12) {
				GameObject.Find ("ui_stage12 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage12").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage13) {
			if (system.clear13) {
				GameObject.Find ("ui_stage13 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage13").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear13) {
				GameObject.Find ("ui_stage13 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage13").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage14) {
			if (system.clear14) {
				GameObject.Find ("ui_stage14 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage14").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear14) {
				GameObject.Find ("ui_stage14 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage14").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage15) {
			if (system.clear15) {
				GameObject.Find ("ui_stage15 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage15").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear15) {
				GameObject.Find ("ui_stage15 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage15").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage16) {
			if (system.clear16) {
				GameObject.Find ("ui_stage16 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage16").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear16) {
				GameObject.Find ("ui_stage16 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage16").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage17) {
			if (system.clear17) {
				GameObject.Find ("ui_stage17 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage17").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear17) {
				GameObject.Find ("ui_stage17 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage17").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage18) {
			if (system.clear18) {
				GameObject.Find ("ui_stage18 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage18").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear18) {
				GameObject.Find ("ui_stage18 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage18").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage19) {
			if (system.clear19) {
				GameObject.Find ("ui_stage19 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage19").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear19) {
				GameObject.Find ("ui_stage19 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage19").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage20) {
			if (system.clear20) {
				GameObject.Find ("ui_stage20 (1)").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			} else {
				GameObject.Find ("ui_stage20").GetComponent<Image> ().color = new Color (beta, beta, beta,1);
			}
		} else {
			if (system.clear20) {
				GameObject.Find ("ui_stage20 (1)").GetComponent<Image> ().color = new Color (1,1,1,1);
			} else {
				GameObject.Find ("ui_stage20").GetComponent<Image> ().color = new Color (1,1,1,1);
			}
		}
		if (isStage1 == true) {
			GameObject.Find ("heishi1").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi2").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage2 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage3 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage4 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage5 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage6 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage7 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage8 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage9 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage10 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		}else if (isStage11 == true) {
			GameObject.Find ("heishi1").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage12 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage13 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage14 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage15 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage16 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage17 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage18 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage19 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		} else if(isStage20 == true){
			GameObject.Find ("heishi1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
			GameObject.Find ("heishi4").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi5").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi6").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi7").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi8").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi9").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi10").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi11").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi12").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi13").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi14").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi15").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi16").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi17").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi18").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi19").GetComponent<Image> ().color = new Color (1, 1, 1, 0);
			GameObject.Find ("heishi20").GetComponent<Image> ().color = new Color (1, 1, 1, 1);
		}


		if(!isBegin){
			if(system.clear1 == true){
				GameObject.Find ("ui_stage1").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage1 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear2 == true){
				GameObject.Find ("ui_stage2").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage2 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear3 == true){
				GameObject.Find ("ui_stage3").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage3 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear4 == true){
				GameObject.Find ("ui_stage4").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage4 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear5 == true){
				GameObject.Find ("ui_stage5").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage5 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear6 == true){
				GameObject.Find ("ui_stage6").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage6 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear7 == true){
				GameObject.Find ("ui_stage7").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage7 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear8 == true){
				GameObject.Find ("ui_stage8").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage8 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear9 == true){
				GameObject.Find ("ui_stage9").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage9 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear10 == true){
				GameObject.Find ("ui_stage10").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage10 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear11 == true){
				GameObject.Find ("ui_stage11").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage11 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear12 == true){
				GameObject.Find ("ui_stage12").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage12 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear13 == true){
				GameObject.Find ("ui_stage13").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage13 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear14 == true){
				GameObject.Find ("ui_stage14").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage14 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear15 == true){
				GameObject.Find ("ui_stage15").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage15 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear16 == true){
				GameObject.Find ("ui_stage16").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage16 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear17 == true){
				GameObject.Find ("ui_stage17").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage17 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear18 == true){
				GameObject.Find ("ui_stage18").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage18 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear19 == true){
				GameObject.Find ("ui_stage19").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage19 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			if(system.clear20 == true){
				GameObject.Find ("ui_stage20").GetComponent<Image>().color = new Color(1, 1, 1, 0);
				GameObject.Find ("ui_stage20 (1)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
			}
			isBegin = true;
		}

	}

	public void stage1(){
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
		beta = 1;
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
	public void stage10(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage10 == true) {
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
			isStage9 = false;
			isStage10 = true;
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
	public void stage11(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage11 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = true;
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
	public void stage12(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage12 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = true;
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
	public void stage13(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage13 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = true;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage14(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage14 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = true;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage15(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage15 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = true;
			isStage16 = false;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage16(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage16 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = true;
			isStage17 = false;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage17(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage17 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = true;
			isStage18 = false;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage18(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage18 == true) {
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
			isStage9 = false;
			isStage10 = false;
			isStage11 = false;
			isStage12 = false;
			isStage13 = false;
			isStage14 = false;
			isStage15 = false;
			isStage16 = false;
			isStage17 = false;
			isStage18 = true;
			isStage19 = false;
			isStage20 = false;
		}
	}
	public void stage19(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage19 == true) {
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
			isStage19 = true;
			isStage20 = false;
		}
	}
	public void stage20(){
		beta = 1;
		if (ui_map_move.isMove == false && isStage20 == true) {
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
			isStage20 = true;
		}
	}
	void OnGUI(){
		texture.SetPixel(0,0,new Color(0,0,0,alpha));
		texture.Apply();
		GUI.DrawTexture(new Rect(0,0,sw,sh), texture);		
		if(isStart == true){
			if(system.stageNum == 1 || system.stageNum == 10 || system.stageNum == 20){}else{
			Application.LoadLevel("mainStage");
			}
			texture.SetPixel(0,0,new Color(0,0,0,alpha));
			texture.Apply();
			GUI.DrawTexture(new Rect(0,0,sw,sh), texture);
			alpha += Time.deltaTime * 1;
			if(alpha > 1.5){
				if(system.stageNum == 1 || system.stageNum == 10 || system.stageNum == 20){
					Application.LoadLevel("Story");
				}
			}
		}
	}
}
