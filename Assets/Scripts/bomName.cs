using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bomName : MonoBehaviour {
	static public string name = "null";
	int ui_bomCount = 0;
	public Vector3 bom1_pos;
	public Vector3 bom2_pos;
	public Vector3 bom3_pos;
	public Vector3 bom4_pos;
	public Vector3 bom5_pos;
	public Vector3 bom6_pos;
	public Vector3 bom7_pos;
	public Vector3 bom8_pos;
	static public bool isBom1;
	static public bool isBom2;
	static public bool isBom3;
	static public bool isBom4;
	static public bool isBom5;
	static public bool isBom6;
	static public bool isBom7;
	static public bool isBom8;
	static public string isName1;
	static public string isName2;
	static public string isName3;
	static public string isName4;
	static public string isName5;
	static public string isName6;
	static public string isName7;
	static public string isName8;

	// Use this for initialization
	void Awake () {
		bom1_pos = new Vector3 (-310, 190, 0);
		bom2_pos = new Vector3 (-180, 190, 0);
		bom3_pos = new Vector3 (-50, 190, 0);
		bom4_pos = new Vector3 (80, 190, 0);
		bom5_pos = new Vector3 (-310, 70, 0);
		bom6_pos = new Vector3 (-180, 70, 0);
		bom7_pos = new Vector3 (-50, 70, 0);
		bom8_pos = new Vector3 (80, 70, 0);

//		this.GetComponent<RectTransform> ().position = bom1_pos;
		this.transform.parent = GameObject.Find("Canvas").transform;
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 1) {
			isBom1 = true;
			isName1 = this.gameObject.name;
			this.gameObject.name = "bom0";
			this.GetComponent<RectTransform> ().anchoredPosition = bom1_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 2) {
			isBom1 = true;
			isBom2 = true;
			isName2 = this.gameObject.name;
			this.gameObject.name = "bom1";
			this.GetComponent<RectTransform> ().anchoredPosition = bom2_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 3) {
			isBom1 = true;
			isBom2 = true;
			isBom3 = true;
			isName3 = this.gameObject.name;
			this.gameObject.name = "bom2";
			this.GetComponent<RectTransform> ().anchoredPosition = bom3_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 4) {
			isBom1 = true;
			isBom2 = true;
			isBom3 = true;
			isBom4 = true;
			isName4 = this.gameObject.name;
			this.gameObject.name = "bom3";
			this.GetComponent<RectTransform> ().anchoredPosition = bom4_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 5) {
			isBom1 = true;
			isBom2 = true;
			isBom3 = true;
			isBom4 = true;
			isBom5 = true;
			isName5 = this.gameObject.name;
			this.gameObject.name = "bom4";
			this.GetComponent<RectTransform> ().anchoredPosition = bom5_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 6) {
			isBom1 = true;
			isBom2 = true;
			isBom3 = true;
			isBom4 = true;
			isBom5 = true;
			isBom6 = true;
			isName6 = this.gameObject.name;
			this.gameObject.name = "bom5";
			this.GetComponent<RectTransform> ().anchoredPosition = bom6_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 7) {
			isBom1 = true;
			isBom2 = true;
			isBom3 = true;
			isBom4 = true;
			isBom5 = true;
			isBom6 = true;
			isBom7 = true;
			isName7 = this.gameObject.name;
			this.gameObject.name = "bom6";
			this.GetComponent<RectTransform> ().anchoredPosition = bom7_pos;
		}
		if (GameObject.FindGameObjectsWithTag ("ui_bom").Length == 8) {
			isBom1 = true;
			isBom2 = true;
			isBom3 = true;
			isBom4 = true;
			isBom5 = true;
			isBom6 = true;
			isBom7 = true;
			isBom8 = true;
			isName8 = this.gameObject.name;
			this.gameObject.name = "bom7";
			this.GetComponent<RectTransform> ().anchoredPosition = bom8_pos;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void pushIcon(){
		name = transform.name;
		Debug.Log("" + isName1);
	}
}
