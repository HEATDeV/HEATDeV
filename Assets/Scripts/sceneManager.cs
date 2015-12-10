using UnityEngine;
using System.Collections;

public class sceneManager : MonoBehaviour {
	static public void clear(){
		if(system.stageNum == 1){
			system.clear1 = true;
		}
		if(system.stageNum == 2){
			system.clear2 = true;
		}
		if(system.stageNum == 3){
			system.clear3 = true;
		}
		if(system.stageNum == 4){
			system.clear4 = true;
		}
		if(system.stageNum == 5){
			system.clear5 = true;
		}
		if(system.stageNum == 6){
			system.clear6 = true;
		}
		if(system.stageNum == 7){
			system.clear7 = true;
		}
		if(system.stageNum == 8){
			system.clear8 = true;
		}
		if(system.stageNum == 9){
			system.clear9 = true;
		}
		if(system.stageNum == 10){
			system.clear10 = true;
		}
		if(system.stageNum == 11){
			system.clear11 = true;
		}
		if(system.stageNum == 12){
			system.clear12 = true;
		}
		if(system.stageNum == 13){
			system.clear13 = true;
		}
		if(system.stageNum == 14){
			system.clear14 = true;
		}
		if(system.stageNum == 15){
			system.clear15 = true;
		}
		if(system.stageNum == 16){
			system.clear16 = true;
		}
		if(system.stageNum == 17){
			system.clear17 = true;
		}
		if(system.stageNum == 18){
			system.clear18 = true;
		}
		if(system.stageNum == 19){
			system.clear19 = true;
		}
		if(system.stageNum == 20){
			system.clear20 = true;
			Application.LoadLevel ("ending");
		}else{Application.LoadLevel ("Select");}
	}
}
