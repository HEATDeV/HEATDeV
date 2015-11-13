using UnityEngine;
using System.Collections;

public class system : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Application.platform == RuntimePlatform.Android) {
			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else if (Application.platform == RuntimePlatform.IPhonePlayer) {
			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else if (Application.platform == RuntimePlatform.WindowsPlayer) {
			QualitySettings.vSyncCount = 0; // VSyncをOFFにする
			Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
		}
		else  {
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
