using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class bomManager : MonoBehaviour {
	static public bool isBomber;
	static public float bomberTime;
	static public GameObject bakuhu;
	static public int num;
	static public int i;
	private int b;
	private int bomCount;
	private GameObject bom;
	private Vector3 hitPos;
	private Animator animator;
	private GameObject colParent;
	public AudioClip createSE;
	public AudioClip changeSE;
	public int finger;
	public List<int> bomLimitLists;
	public List<GameObject> bomLists;

	float t;
	bool isTimeBomStart;

	GameObject[] boms;

	private GameObject child;

	void Start(){
		bom = null;
		isBomber = false;
		bomberTime = 0;
		num = -1;
		bomCount = GameObject.FindGameObjectsWithTag("ui_bom").Length;
		boms = GameObject.FindGameObjectsWithTag("bom");
		for(int i = 1; i <= bomCount; i++){
			bomLimitLists.Add (i);
		}
		for(int i = 0; i < 10; i++){
			if(GameObject.Find ("bom"+i) != null){
				bomLists.Add (GameObject.Find ("bom"+i));
			}else{
				break;
			}
		}
	}

	void Update(){
		boms = GameObject.FindGameObjectsWithTag("bom");

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray,out hit) && bomLimitLists.Count != 0 && isBomber == false && Input.touchCount == finger && num != -1){
				hitPos = hit.point;
				if(hit.collider.gameObject.tag == "stage"){
					if(EventSystem.current.IsPointerOverGameObject()){
						return;
					}
					colParent = hit.collider.gameObject;
					createBom();
					bomLimitLists.RemoveAt(0);
				}
			}	
		}

		if (isTimeBomStart){
			t += 1.0f * Time.deltaTime;
			if (1 < t){
				for (int i = 0; i < boms.Length; i ++) {
					if (boms[i].transform.name == "bom_time(Clone)"){
						bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_time"),boms[i].transform.position,Quaternion.identity)as GameObject;
						Destroy(boms[i].gameObject);
					}
				}
			}
		}
	}

	public void bomber(){
		for (int i = 0; i < boms.Length; i ++) {
			if (boms[i].transform.name == "bom_big(Clone)"){
				bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_big"),boms[i].transform.position,Quaternion.identity)as GameObject;
				Destroy(boms[i].gameObject);
			}
			if (boms[i].transform.name == "bom_middle(Clone)"){
				bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_middle"),boms[i].transform.position,Quaternion.identity)as GameObject;
				Destroy(boms[i].gameObject);
			}
			if (boms[i].transform.name == "bom_small(Clone)"){
				bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_small"),boms[i].transform.position,Quaternion.identity)as GameObject;
				Destroy(boms[i].gameObject);
			}
			if (boms[i].transform.name == "bom_upper(Clone)"){
				bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_upper"),boms[i].transform.position,Quaternion.identity)as GameObject;
				Destroy(boms[i].gameObject);
			}
			if (boms[i].transform.name == "bom_side(Clone)"){
				bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_side"),boms[i].transform.position,Quaternion.identity)as GameObject;
				Destroy(boms[i].gameObject);
			}
			if (boms[i].transform.name == "bom_time(Clone)"){
				isTimeBomStart = true;
			}

		}
		isBomber = true;

	}

	public void change_smallBom(){
		GetComponent<AudioSource> ().PlayOneShot (changeSE);
		num = 0;
		Debug.Log (""+bomName.name);
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name){
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",true);
			}else{
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",false);
			}
		}
	}
	public void change_middleBom(){
		GetComponent<AudioSource> ().PlayOneShot (changeSE);
		num = 1;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",true);
			}else{
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",false);
			}
		}
	}
	public void change_bigBom(){
		GetComponent<AudioSource> ().PlayOneShot (changeSE);
		num = 2;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",true);
			}else{
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",false);
			}
		}
	}
	public void change_upperBom(){
		GetComponent<AudioSource> ().PlayOneShot (changeSE);
		num = 3;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",true);
			}else{
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",false);
			}
		}
	}
	public void change_sideBom(){
		GetComponent<AudioSource> ().PlayOneShot (changeSE);
		num = 4;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",true);
			}else{
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",false);
			}
		}
	}
	public void change_timeBom(){
		GetComponent<AudioSource> ().PlayOneShot (changeSE);
		num = 5;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",true);
			}else{
				animator = bomLists[a].GetComponent<Animator>();
				animator.SetBool("isBom",false);
			}
		}
	}

	void createBom(){
		GetComponent<AudioSource> ().PlayOneShot (createSE);
		if(num == 0){
			bom = Instantiate(Resources.Load("bom_small"),new Vector3(hitPos.x, hitPos.y + 0.25f, hitPos.z),Quaternion.identity)as GameObject;
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 1){
			bom = Instantiate(Resources.Load("bom_middle"),new Vector3(hitPos.x, hitPos.y + 1.25f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 2){
			bom = Instantiate(Resources.Load("bom_big"),new Vector3(hitPos.x, hitPos.y + 1.25f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 3){
			bom = Instantiate(Resources.Load("bom_upper"),new Vector3(hitPos.x, hitPos.y + 1.25f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 4){
			bom = Instantiate(Resources.Load("bom_side"),new Vector3(hitPos.x, hitPos.y + 1.25f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 5){
			bom = Instantiate(Resources.Load("bom_time"),new Vector3(hitPos.x, hitPos.y + 1.25f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		i = num;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				bomLists[a].gameObject.GetComponent<Image>().enabled = false;
				bomLists[a].gameObject.GetComponent<Button>().enabled = false;
			}
		}
	}
}
