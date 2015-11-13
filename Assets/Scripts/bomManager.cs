using UnityEngine;
using System.Collections.Generic;

public class bomManager : MonoBehaviour {
	static public bool isBomber;
	static public float bomberTime;
	static public GameObject bakuhu;
	static public int num;
	static public int i;
	private int bomCount;
	private GameObject bom;
	private Vector3 hitPos;
	public List<int> bomLimitLists;
	public List<GameObject> bomLists;

	void Start(){
		isBomber = false;
		bomberTime = 0;
		num = -1;
		bomCount = GameObject.FindGameObjectsWithTag("ui_bom").Length;
		for(int i = 1; i <= bomCount; i++){
			bomLimitLists.Add (i);
		}
		bomLists.Add (GameObject.Find ("bom1"));
		bomLists.Add (GameObject.Find ("bom2"));
		bomLists.Add (GameObject.Find ("bom3"));
		bomLists.Add (GameObject.Find ("bom4"));
		bomLists.Add (GameObject.Find ("bom5"));
		bomLists.Add (GameObject.Find ("bom6"));
	}

	void Update(){
		if(isBomber == true){
			bomberTime += Time.deltaTime;
		}
		if(bomLimitLists.Count > 0 && bomberTime > 0.5f){
			isBomber = false;
			bomberTime = 0;
		}

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray,out hit) && bomLimitLists.Count != 0 && isBomber == false/* && Input.touchCount == 1*/){
				hitPos = hit.point;
				if(hit.collider.gameObject.tag == "stage"){
					createBom();
					bomLimitLists.RemoveAt(0);
					num = -1;
				}
				/*				if (Application.platform == RuntimePlatform.Android && Input.touchCount == 1) {
					hitPos = hit.point;
					if(hit.collider.gameObject.tag == "stage"){
						if(num == 0){
							bom = Instantiate(
								Resources.Load("bom_small"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(num == 1){
							bom = Instantiate(
								Resources.Load("bom_middle"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(num == 2){
							bom = Instantiate(
								Resources.Load("bom_big"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						bomLimitLists.Count --;
					}
				}else if (Application.platform == RuntimePlatform.IPhonePlayer && Input.touchCount == 1) {
					hitPos = hit.point;
					if(hit.collider.gameObject.tag == "stage"){
						if(num == 0){
							bom = Instantiate(
								Resources.Load("bom_small"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(num == 1){
							bom = Instantiate(
								Resources.Load("bom_middle"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(num == 2){
							bom = Instantiate(
								Resources.Load("bom_big"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						bomLimitLists.Count --;
					}
				}else{
					hitPos = hit.point;
					if(hit.collider.gameObject.tag == "stage"){
						if(num == 0){
							bom = Instantiate(
								Resources.Load("bom_small"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(num == 1){
							bom = Instantiate(
								Resources.Load("bom_middle"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(num == 2){
							bom = Instantiate(
								Resources.Load("bom_big"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						bomLimitLists.Count --;
					}
				}*/
			}	
		}
	}

	static public void smallBom(){
		bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_small"),bomSystem_small.me.transform.position,Quaternion.identity)as GameObject;
		Destroy(bomSystem_small.me.gameObject);
	}

	static public void middleBom(){
		bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_middle"),bomSystem_middle.me.transform.position,Quaternion.identity)as GameObject;
		Destroy(bomSystem_middle.me.gameObject);
	}

	static public void bigBom(){
		bakuhu = Instantiate (Resources.Load ("prefab/bakuhatu_big"),bomSystem_big.me.transform.position,Quaternion.identity)as GameObject;
		Destroy(bomSystem_big.me.gameObject);
	}

	public void bomber(){
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
			bom = Instantiate(Resources.Load("bom_small"),hitPos,Quaternion.identity)as GameObject;	
		}
		if(num == 1){
			bom = Instantiate(Resources.Load("bom_middle"),hitPos,Quaternion.identity)as GameObject;	
		}
		if(num == 2){
			bom = Instantiate(Resources.Load("bom_big"),hitPos,Quaternion.identity)as GameObject;	
		}
		if(num == 3){
			bom = Instantiate(Resources.Load("bom_small"),hitPos,Quaternion.identity)as GameObject;	
		}
		if(num == 4){
			bom = Instantiate(Resources.Load("bom_middle"),hitPos,Quaternion.identity)as GameObject;	
		}
		if(num == 5){
			bom = Instantiate(Resources.Load("bom_big"),hitPos,Quaternion.identity)as GameObject;	
		}
		i = num;
		bomLists[i].GetComponent<CanvasRenderer>().SetAlpha(0);
	}
}
