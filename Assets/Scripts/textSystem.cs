﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textSystem : MonoBehaviour {
	public Text text;
	
	// Update is called once per frame
	void Update () {
        if(system.stageID == 1)
        {
		    text.text = "道を通れるようにしてください";
        }
		else if(system.stageID == 2)
        {
			text.text = "右の家は壊さないでください";
        }
		else if(system.stageID == 3)
		{
			text.text = "敵兵士を全員落としてください";
		}
		else if(system.stageID == 4)
		{
			text.text = "魔王を倒し、姫を救ってください";
		}
	}
}
