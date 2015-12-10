using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Scene : ICommand
{
	public string Tag {
		get {	return "scene"; }
	}

	public void Command (Dictionary<string, string> command)
	{
		storyManager.isStart = true;
		GameObject.Find("ui_black").GetComponent<Animator>().SetBool("isBlack",true);
		if(storyManager.alpha > 1.4){
			Application.LoadLevel(command["scene"]);
		}
	}	
}

