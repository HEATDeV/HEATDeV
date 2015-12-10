/*using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class batsu : MonoBehaviour {
	public Camera camera;
	public Transform target;
	Vector2 viewPos;
	float alpha;
	bool isDraw;
	RectTransform myRectTrans;
	RectTransform parentRectTrans;
	
	void Awake(){
		myRectTrans = GetComponent<RectTransform>();
		parentRectTrans = (RectTransform)myRectTrans.parent;
	}
	
	void Start () {
		alpha = 1.0f;
		isDraw = false;
		viewPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (clearHantei.colOb != null && clearHantei.deadTimer > 3f || nonCol.colMe != null && clearHantei.deadTimer > 3f)
		{
			if (clearHantei.colOb != null && nonCol.colMe == null)
			{
				target = clearHantei.colOb.transform;
			}
			if (nonCol.colMe != null)
			{
				target = nonCol.colMe.transform;
			}
			if(enemyManager.enemyOb != null){
				target = enemyManager.enemyOb.transform;
			}
			var screenPos = GameObject.Find("Main Camera").GetComponent<Camera>().WorldToScreenPoint(target.position);
			var localPos = Vector2.zero;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTrans, screenPos, GameObject.Find("Main Camera").GetComponent<Camera>(), out localPos);
			myRectTrans.localPosition = localPos;
		}
	}
}*/
