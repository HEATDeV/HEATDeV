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
		Application.LoadLevel(command["scene"]);
	}
}

