using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Music : ICommand
{
	public string Tag {
		get {	return "music"; }
	}

	public void Command (Dictionary<string, string> command)
	{
		GameObject camera = GameObject.Find("Main Camera");
		AudioSource audioSource;
		audioSource = camera.GetComponent<AudioSource>();

		if(command["BGM"] == "null")
			audioSource.clip = null;
		audioSource.clip = (AudioClip)Resources.Load("Sound/bgm_game.ogg/bgm_game.ogg/" + command["BGM"]);
		audioSource.Play();
	}
}
