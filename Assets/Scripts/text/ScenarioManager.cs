﻿using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

[RequireComponent(typeof( TextController))]
public class ScenarioManager : MonoBehaviour {
	
	private string LoadFileName;
	
	private string[] m_scenarios;
	private int m_currentLine = 0;
	private bool m_isCallPreload = false;
	bool next = false;
	
	private TextController m_textController;
	private CommandController m_commandController;

	void Awake(){
		if(system.stageNum == 1){
			LoadFileName = "stage1";
		}
		if(system.stageNum == 10){
			LoadFileName = "stage10";
		}
		if(system.stageNum == 20){
			LoadFileName = "stage20";
		}
		if(Application.loadedLevelName == "ending"){
			LoadFileName = "ending";
		}
	}

	void RequestNextLine ()
	{
		var currentText = m_scenarios[m_currentLine];
		
		m_textController.SetNextLine(CommandProcess(currentText));
		m_currentLine ++;
		m_isCallPreload = false;
	}
	
	public void UpdateLines(string fileName)
	{
		var scenarioText = Resources.Load<TextAsset>("Scenario/" + fileName);
		
		if( scenarioText == null ){
			Debug.LogError("シナリオファイルが見つかりませんでした");
			Debug.LogError("ScenarioManagerを無効化します");
			enabled = false;
			return;
		}
		m_scenarios = scenarioText.text.Split(new string[]{"@br"}, System.StringSplitOptions.None);
		m_currentLine = 0;
		
		Resources.UnloadAsset(scenarioText);
	}
	
	private string CommandProcess(string line)
	{
		var lineReader = new StringReader(line);
		var lineBuilder = new StringBuilder();
		var text = string.Empty;
		while( (text = lineReader.ReadLine()) != null )
		{
			var commentCharacterCount = text.IndexOf("//");
			if( commentCharacterCount != -1 ){
				text = text.Substring(0, commentCharacterCount );
			}
			
			if(! string.IsNullOrEmpty( text )  ){
				if( text[0] == '@' &&  m_commandController.LoadCommand(text))
					continue;
				lineBuilder.AppendLine(text);
			}
		}
		
		return lineBuilder.ToString();
	}
	
	#region UNITY_CALLBACK
	
	void Start () {
		m_textController = GetComponent<TextController>();
		m_commandController = GetComponent<CommandController>();
		
		UpdateLines(LoadFileName);
		RequestNextLine();
	}
	
	void Update () 
	{
		if( m_textController.IsCompleteDisplayText  ){
			if( m_currentLine < m_scenarios.Length)
			{
				if( !m_isCallPreload )
				{
					m_commandController.PreloadCommand(m_scenarios[m_currentLine]);
					m_isCallPreload = true;
				}
				
				if( /*Input.GetMouseButtonDown(0) && */next){
					RequestNextLine();
					next = false;
				}
			}
		}else{
			if(/*Input.GetMouseButtonDown(0) && */next){
				m_textController.ForceCompleteDisplayText();
				next = false;
			}
		}
	}

	public void Next(){
		next = true;
	}

	public void Skip(){
		storyManager.isStart = true;
		GameObject.Find("ui_black").GetComponent<Animator>().SetBool("isBlack",true);
	}
	
	#endregion
}