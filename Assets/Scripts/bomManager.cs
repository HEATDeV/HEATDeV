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
		Debug.Log ("" + num);
		boms = GameObject.FindGameObjectsWithTag("bom");


		if(isBomber == true){
			bomberTime += Time.deltaTime;
		}
		if(bomLimitLists.Count > 0 && bomberTime > 1.5f){
			isBomber = false;
			bomberTime = 0;
		}

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray,out hit) && bomLimitLists.Count != 0 && isBomber == false && Input.touchCount == finger){
				hitPos = hit.point;
				if(hit.collider.gameObject.tag == "stage" || hit.collider.gameObject.tag == "field"){
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
		num = 0;
	}
	public void change_middleBom(){
		num = 1;
	}
	public void change_bigBom(){
		num = 2;
	}
	public void change_upperBom(){
		num = 3;
	}
	public void change_sideBom(){
		num = 4;
	}
	public void change_timeBom(){
		num = 5;
	}

	void createBom(){
		if(num == 0){
			bom = Instantiate(Resources.Load("bom_small"),new Vector3(hitPos.x, hitPos.y + 0.5f, hitPos.z),Quaternion.identity)as GameObject;
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 1){
			bom = Instantiate(Resources.Load("bom_middle"),new Vector3(hitPos.x, hitPos.y + 0.5f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 2){
			bom = Instantiate(Resources.Load("bom_big"),new Vector3(hitPos.x, hitPos.y + 0.5f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 3){
			bom = Instantiate(Resources.Load("bom_upper"),new Vector3(hitPos.x, hitPos.y + 0.5f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 4){
			bom = Instantiate(Resources.Load("bom_side"),new Vector3(hitPos.x, hitPos.y + 0.5f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		if(num == 5){
			bom = Instantiate(Resources.Load("bom_time"),new Vector3(hitPos.x, hitPos.y + 0.5f, hitPos.z),Quaternion.identity)as GameObject;	
			bom.transform.parent = colParent.transform;
			num = -1;
		}
		i = num;
		for(int a = 0; a < 10; a++){
			if(bomLists[a].gameObject.name == bomName.name && bomName.name != "null"){
				//bomLists[a].gameObject.GetComponent<CanvasRenderer>().SetAlpha(0);
				bomLists[a].gameObject.GetComponent<Image>().enabled = false;
				bomLists[a].gameObject.GetComponent<Button>().enabled = false;
			}
		}
	}
}
