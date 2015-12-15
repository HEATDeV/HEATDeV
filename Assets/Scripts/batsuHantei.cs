using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class batsuHantei : MonoBehaviour {
	public int num = 1;
	public int ID;
	bool isLoad;
	static public string nowName = "aiueo";
	static public int loadID;
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
		num = 1;
        alpha = 1.0f;
		loadID = 1;
		isLoad = false;
        isDraw = false;
        viewPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(num <= 100){
			num ++;
		}
		if(this.name == "batsu_" + num){
			ID = num;
		}
		if(ID == loadID){
			if (clearHantei.colOb != null && clearHantei.deadTimer > 6.5f || nonCol.colMe != null && clearHantei.deadTimer > 6.5f)
	        {
				if (clearHantei.colOb != null)
				{
					target = clearHantei.colOb.transform;
					clearHantei.colOb.tag = "deadOb";
				}
				if (nonCol.colMe != null)
				{
					target = nonCol.colMe.transform;
					nonCol.colMe.tag = "deadOb";
				}
				if(enemyManager.enemyOb != null){
					target = enemyManager.enemyOb.transform;
					enemyManager.enemyOb.tag = "deadEnemy";
				}
				if(princess.priOb != null){
					target = princess.priOb.transform;
					princess.priOb.tag = "deadPri";
				}

				if(target.name != batsuHantei.nowName){
					batsuHantei.loadID ++;
					isLoad = true;
				}

				if (clearHantei.colOb != null && nonCol.colMe == null)
				{
					batsuHantei.nowName = clearHantei.colOb.name;
				}
				if (nonCol.colMe != null)
				{
					batsuHantei.nowName = nonCol.colMe.name;
					nonCol.colMe = null;
				}
				if(enemyManager.enemyOb != null){
					batsuHantei.nowName = enemyManager.enemyOb.name;
				}
				if(princess.priOb != null){
					batsuHantei.nowName = princess.priOb.name;
					princess.priOb = null;
				}
			}
		}

		if(isLoad){		
            var screenPos = GameObject.Find("Main Camera").GetComponent<Camera>().WorldToScreenPoint(target.position);
            var localPos = Vector2.zero;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTrans, screenPos, GameObject.Find("Main Camera").GetComponent<Camera>(), out localPos);
            myRectTrans.localPosition = localPos;
            if (bomManager.isBomber == true)
            {
                if (alpha < 1.0f)
                {
                    alpha += 0.1f * Time.deltaTime * 60.0f;
                }
                else
                {
                    alpha = 1.0f;
                }
            }
            else
            {
                if (alpha > 0.0f)
                {
                    alpha -= 0.4f * Time.deltaTime * 60.0f;
                }
                else
                {
                    alpha = 0.0f;
                }
            }
            this.GetComponent<Image>().color = new Color(1, 1, 1, alpha * 0.5f);
		}
	}
}
