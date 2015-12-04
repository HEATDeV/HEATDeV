﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	Vector2 slideStartPosition;
	Vector2 prevPosition;
	Vector2 delta = Vector2.zero;
	bool moved = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
			slideStartPosition = GetCursorPoiotion();

		if(Input.GetButton("Fire1")){
			if(Vector2.Distance (slideStartPosition, GetCursorPoiotion()) >= (Screen.width * 0.1f))
				moved = true;
		}

		if(!Input.GetButtonUp ("Fire1") && !Input.GetButton("Fire1"))
			moved = false;

		if(moved)
			delta = GetCursorPoiotion () - prevPosition;
		else
			delta = Vector2.zero;

		prevPosition = GetCursorPoiotion ();
	}

	public bool Clicked(){
		if(!moved && Input.GetButtonUp("Fire1"))
			return true;
		else
			return false;

	}

	public Vector2 GetDeltaPosition(){
		return delta;
	}

	public bool Moved(){
		return moved;
	}

	public Vector2 GetCursorPoiotion(){
		return Input.mousePosition;
	}

}
