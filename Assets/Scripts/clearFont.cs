using UnityEngine;
using System.Collections;

public class clearFont : MonoBehaviour {
	public AudioClip clearSE;
	private Animator animator;
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
		enemyCount =  GameObject.FindGameObjectsWithTag("enemy").Length;
	}
	// Update is called once per frame
	void Update () {
		if(enemyCount != 0){
			enemyCount =  GameObject.FindGameObjectsWithTag("enemy").Length;
		}
		if(deadLine.isClear == true && nonCol.isDamage == false && enemyCount == 0){
			isSE = true;
			animator.SetBool("isClear",true);
		} else if(deadLine.isClear == false || nonCol.isDamage == true || enemyCount != 0){
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
