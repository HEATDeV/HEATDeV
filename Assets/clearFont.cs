using UnityEngine;
using System.Collections;

public class clearFont : MonoBehaviour {
	public AudioClip clearSE;
	private Animator animator;
	public bool isSE;
	private float timer;
	// Use this for initialization
	void Start () {
		isSE = false;
		timer = 0;
		animator = GetComponent<Animator>();

	}
	// Update is called once per frame
	void Update () {
		if(deadLine.isClear == true){
			isSE = true;
			animator.SetBool("isClear",true);
		}
		if(isSE == true){
			timer += Time.deltaTime;
			if(timer > 1f){
				GetComponent<AudioSource>().PlayOneShot(clearSE);
				timer = -1000f;
			}
			if(timer  > -997f && timer < -500f){
				sceneManager.clear();
			}
		}
	}
}
