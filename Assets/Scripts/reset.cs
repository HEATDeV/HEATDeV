using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {
	public void Reset(){
		Application.LoadLevel (Application.loadedLevelName);
	}
}
