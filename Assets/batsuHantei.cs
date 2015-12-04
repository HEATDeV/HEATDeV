﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class batsuHantei : MonoBehaviour {
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