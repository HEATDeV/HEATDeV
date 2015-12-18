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
	int frame;
	bool isStart;
	GameObject[] boms;
	static public int bomLim;
	bool isBomLim;
	static public int limNum;
	private GameObject child;
	bool isPush;
	float pushTimer;
	void Start(){
		bom = null;
		isBomLim = false;
		isBomber = false;
		isStart = false;
		isPush = false;
		bomberTime = 0;
		pushTimer = 0;
		num = -1;
		frame = 0;
		bomLim = -1;
	}

	void Update(){
		if(isPush){
			pushTimer += Time.deltaTime;
		}
		if(pushTimer > 0.75f && !isBomber){
			bomber();
		}
		if(bomLim == limNum && isBomber == true){
			isBomber = false;
		}
		if(frame < 60){
			frame ++;
		}
		if(frame > 3 && isStart == false){
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
			isStart = true;
		}

		if(isBomLim == false && bomLimitLists.Count == bomCount && frame > 10){
			bomLim = bomCount;
			limNum = bomLim;
			isBomLim = true;
		}

		if(bomName.isBom1 == true){
			if(bomName.isName1 == "bom0(Clone)"){
				GameObject.Find("bom0").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName1 == "bom1(Clone)"){
				GameObject.Find("bom0").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName1 == "bom2(Clone)"){
				GameObject.Find("bom0").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName1 == "bom3(Clone)"){
				GameObject.Find("bom0").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName1 == "bom4(Clone)"){
				GameObject.Find("bom0").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName1 == "bom5(Clone)"){
				GameObject.Find("bom0").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom1 = false;
		}
		if(bomName.isBom2 == true){
			if(bomName.isName2 == "bom0(Clone)"){
				GameObject.Find("bom1").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName2 == "bom1(Clone)"){
				GameObject.Find("bom1").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName2 == "bom2(Clone)"){
				GameObject.Find("bom1").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName2 == "bom3(Clone)"){
				GameObject.Find("bom1").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName2 == "bom4(Clone)"){
				GameObject.Find("bom1").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName2 == "bom5(Clone)"){
				GameObject.Find("bom1").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom2 = false;
		}
		if(bomName.isBom3 == true){
			if(bomName.isName3 == "bom0(Clone)"){
				GameObject.Find("bom2").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName3 == "bom1(Clone)"){
				GameObject.Find("bom2").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName3 == "bom2(Clone)"){
				GameObject.Find("bom2").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName3 == "bom3(Clone)"){
				GameObject.Find("bom2").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName3 == "bom4(Clone)"){
				GameObject.Find("bom2").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName3 == "bom5(Clone)"){
				GameObject.Find("bom2").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom3 = false;
		}
		if(bomName.isBom4 == true){
			if(bomName.isName4 == "bom0(Clone)"){
				GameObject.Find("bom3").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName4 == "bom1(Clone)"){
				GameObject.Find("bom3").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName4 == "bom2(Clone)"){
				GameObject.Find("bom3").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName4 == "bom3(Clone)"){
				GameObject.Find("bom3").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName4 == "bom4(Clone)"){
				GameObject.Find("bom3").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName4 == "bom5(Clone)"){
				GameObject.Find("bom3").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom4 = false;
		}
		if(bomName.isBom5 == true){
			if(bomName.isName5 == "bom0(Clone)"){
				GameObject.Find("bom4").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName5 == "bom1(Clone)"){
				GameObject.Find("bom4").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName5 == "bom2(Clone)"){
				GameObject.Find("bom4").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName5 == "bom3(Clone)"){
				GameObject.Find("bom4").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName5 == "bom4(Clone)"){
				GameObject.Find("bom4").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName5 == "bom5(Clone)"){
				GameObject.Find("bom4").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom5 = false;
		}
		if(bomName.isBom6 == true){
			if(bomName.isName6 == "bom0(Clone)"){
				GameObject.Find("bom5").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName6 == "bom1(Clone)"){
				GameObject.Find("bom5").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName6 == "bom2(Clone)"){
				GameObject.Find("bom5").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName6 == "bom3(Clone)"){
				GameObject.Find("bom5").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName6 == "bom4(Clone)"){
				GameObject.Find("bom5").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName6 == "bom5(Clone)"){
				GameObject.Find("bom5").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom6 = false;
		}
		if(bomName.isBom7 == true){
			if(bomName.isName7 == "bom0(Clone)"){
				GameObject.Find("bom6").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName7 == "bom1(Clone)"){
				GameObject.Find("bom6").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName7 == "bom2(Clone)"){
				GameObject.Find("bom6").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName7 == "bom3(Clone)"){
				GameObject.Find("bom6").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName7 == "bom4(Clone)"){
				GameObject.Find("bom6").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName7 == "bom5(Clone)"){
				GameObject.Find("bom6").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom7 = false;
		}
		if(bomName.isBom8 == true){
			if(bomName.isName8 == "bom0(Clone)"){
				GameObject.Find("bom7").GetComponent<Button> ().onClick.AddListener (change_smallBom);
			}else if(bomName.isName8 == "bom1(Clone)"){
				GameObject.Find("bom7").GetComponent<Button> ().onClick.AddListener (change_middleBom);
			}else if(bomName.isName8 == "bom2(Clone)"){
				GameObject.Find("bom7").GetComponent<Button> ().onClick.AddListener (change_bigBom);
			}else if(bomName.isName8 == "bom3(Clone)"){
				GameObject.Find("bom7").GetComponent<Button> ().onClick.AddListener (change_upperBom);
			}else if(bomName.isName8 == "bom4(Clone)"){
				GameObject.Find("bom7").GetComponent<Button> ().onClick.AddListener (change_sideBom);
			}else if(bomName.isName8 == "bom5(Clone)"){
				GameObject.Find("bom7").GetComponent<Button> ().onClick.AddListener (change_timeBom);
			}
			bomName.isBom8 = false;
		}

		boms = GameObject.FindGameObjectsWithTag("bom");

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray,out hit) && bomLimitLists.Count != 0 && isBomber == false/* && Input.touchCount == finger*/ && num != -1){
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

	public void push_bomber(){
		if (bomLim != limNum) {
			isPush = true;
			GameObject.Find ("character_soldier_A").GetComponent<Animator> ().SetBool ("isBomber", true);
			GameObject.Find ("P_Box_A").GetComponent<MeshRenderer> ().enabled = true;
			GameObject.Find ("B_Rod_A").GetComponent<MeshRenderer> ().enabled = true;
			GameObject.Find ("character_soldier_B").GetComponent<Animator> ().SetBool ("isBomber", true);
			GameObject.Find ("P_Box_B").GetComponent<MeshRenderer> ().enabled = true;
			GameObject.Find ("B_Rod_B").GetComponent<MeshRenderer> ().enabled = true;
			GameObject.Find ("character_soldier_C").GetComponent<Animator> ().SetBool ("isBomber", true);
			GameObject.Find ("P_Box_C").GetComponent<MeshRenderer> ().enabled = true;
			GameObject.Find ("B_Rod_C").GetComponent<MeshRenderer> ().enabled = true;
		}
	}

	void bomber(){
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
//		Debug.Log (""+bomName.name);
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
		limNum -= 1;
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

	public void reset (){
		num = -1;
		clearHantei.deadTimer = 0;
		Application.LoadLevel ("mainStage");
	}
}
