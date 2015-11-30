using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textSystem : MonoBehaviour {
	public Text text;
	
	// Update is called once per frame
	void Update () {
        if(system.stageNum == 1)
        {
		    text.text = "道を通れるようにしてください";
        }
        else
        {
            text.text = "右の家は壊さないでください";
        }
	}
}
