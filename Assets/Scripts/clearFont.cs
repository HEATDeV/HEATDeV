using UnityEngine;
using System.Collections;

public class clearFont : MonoBehaviour {
	public AudioClip clearSE;
	private Animator animator;
	private Animator anim_victory;
	private Animator anim_camera;
	public bool isSE;
	private float timer;
	private float batsuTimer;
	private int enemyCount;
	// Use this for initialization
	void Start () {
		isSE = false;
		timer = 0;
		batsuTimer = 0;
		animator = GetComponent<Animator>();
		anim_victory = GameObject.Find ("character_soldier").GetComponent<Animator>();
		anim_camera = GameObject.Find ("cameraMove").GetComponent<Animator>();
		enemyCount =  GameObject.FindGameObjectsWithTag("enemy").Length;
	}
	// Update is called once per frame
	void Update () {
		if(enemyCount != 0){
			enemyCount =  GameObject.FindGameObjectsWithTag("enemy").Length;
		}
		if(deadLine.isClear == true && nonCol.isDamage == false && enemyCount == 0 && isSE == false){
			if(system.stageNum == 20){
				if(princess.isPrincess){
					isSE = true;
					GameObject.Find ("Main Camera").transform.eulerAngles = new Vector3(10, 0, 0);
					GameObject.Find ("Main Camera").transform.position = new Vector3(-0.6f, 16.4f, -30.9f);
					GameObject.Find ("Main Camera").GetComponent<CameraCtrl>().enabled = false;
					anim_camera.SetBool("isClear",true);
					anim_victory.SetBool("isVictory",true);
					animator.SetBool("isClear",true);
				}
			}else{
				isSE = true;
				GameObject.Find ("Main Camera").transform.eulerAngles = new Vector3(10, 0, 0);
				GameObject.Find ("Main Camera").transform.position = new Vector3(-0.6f, 16.4f, -30.9f);
				GameObject.Find ("Main Camera").GetComponent<CameraCtrl>().enabled = false;
				anim_camera.SetBool("isClear",true);
				anim_victory.SetBool("isVictory",true);
				animator.SetBool("isClear",true);
			}
		} else if(deadLine.isClear == false || nonCol.isDamage == true || enemyCount != 0 || princess.isPrincess == false){
			if(bomManager.limNum < bomManager.bomLim){
				batsuTimer += Time.deltaTime;
				if(clearHantei.deadTimer > 8f){
					animator.SetBool("isBad",true);
				}
			}
		}
		if(isSE == true){
			timer += Time.deltaTime;
			if(timer > 0.5f){
				GetComponent<AudioSource>().PlayOneShot(clearSE);
				timer = -1000f;
			}
			if(timer  > -997f && timer < -500f){
				sceneManager.clear();
			}
		}
	}
}
