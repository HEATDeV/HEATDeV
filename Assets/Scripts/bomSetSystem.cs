using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class bomSetSystem : MonoBehaviour {
	GameObject bom;
	Vector3 hitPos;
	public int kaisu;
	int bomCount;
	public int bomLimit;
	GameObject bS;
	Touch touch;
	// Use this for initialization
	void Start () {
		bS = GameObject.Find ("gameSystem");
		kaisu = 0;
	}
	
	// Update is called once per frame
	void Update () {
		bomCount = GameObject.FindGameObjectsWithTag ("bom").Length;

		if(bomLimit < 1){
			GameObject.Find("bom1").GetComponent<CanvasRenderer>().SetAlpha(0);
		}
		if(bomLimit < 2){
			GameObject.Find("bom2").GetComponent<CanvasRenderer>().SetAlpha(0);
		}
		if(bomLimit < 3){
			GameObject.Find("bom3").GetComponent<CanvasRenderer>().SetAlpha(0);
		}
		if(bomLimit < 4) {
			GameObject.Find ("bom4").GetComponent<CanvasRenderer> ().SetAlpha (0);
		}
		if(bomLimit < 5) {
			GameObject.Find ("bom5").GetComponent<CanvasRenderer> ().SetAlpha (0);
		}
		if(bomLimit < 6) {
			GameObject.Find ("bom6").GetComponent<CanvasRenderer> ().SetAlpha (0);
		}

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray,out hit) && bomLimit != 0 && bS.GetComponent<bomberSystem>().isBomber == false && Input.touchCount == 1){
				hitPos = hit.point;
				if(hit.collider.gameObject.tag == "stage"){
					if(kaisu == 0){
						bom = Instantiate(
							Resources.Load("bom_small"),
							hitPos,
							Quaternion.identity)as GameObject;	
					}
					if(kaisu == 1){
						bom = Instantiate(
							Resources.Load("bom_middle"),
							hitPos,
							Quaternion.identity)as GameObject;	
					}
					if(kaisu == 2){
						bom = Instantiate(
							Resources.Load("bom_big"),
							hitPos,
							Quaternion.identity)as GameObject;	
					}
					bomLimit --;
				}
/*				if (Application.platform == RuntimePlatform.Android && Input.touchCount == 1) {
					hitPos = hit.point;
					if(hit.collider.gameObject.tag == "stage"){
						if(kaisu == 0){
							bom = Instantiate(
								Resources.Load("bom_small"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(kaisu == 1){
							bom = Instantiate(
								Resources.Load("bom_middle"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(kaisu == 2){
							bom = Instantiate(
								Resources.Load("bom_big"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						bomLimit --;
					}
				}else if (Application.platform == RuntimePlatform.IPhonePlayer && Input.touchCount == 1) {
					hitPos = hit.point;
					if(hit.collider.gameObject.tag == "stage"){
						if(kaisu == 0){
							bom = Instantiate(
								Resources.Load("bom_small"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(kaisu == 1){
							bom = Instantiate(
								Resources.Load("bom_middle"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(kaisu == 2){
							bom = Instantiate(
								Resources.Load("bom_big"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						bomLimit --;
					}
				}else{
					hitPos = hit.point;
					if(hit.collider.gameObject.tag == "stage"){
						if(kaisu == 0){
							bom = Instantiate(
								Resources.Load("bom_small"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(kaisu == 1){
							bom = Instantiate(
								Resources.Load("bom_middle"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						if(kaisu == 2){
							bom = Instantiate(
								Resources.Load("bom_big"),
								hitPos,
								Quaternion.identity)as GameObject;	
						}
						bomLimit --;
					}
				}*/
			}

		}
	}
	public void bomChange(){
		kaisu ++;
		if(kaisu == 3){
			kaisu = 0;
		}
	}
}

