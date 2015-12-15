using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Chara : ICommand
{
    public string Tag {
		get {	return "image"; }
	}
	
	public void Command (Dictionary<string, string> command)
	{
		GameObject himeL = GameObject.Find("himeL");
		GameObject himeR = GameObject.Find("himeR");
		GameObject maouL = GameObject.Find("maouL");
		GameObject maouR = GameObject.Find("maouR");
		GameObject ouL = GameObject.Find("ouL");
		GameObject ouR = GameObject.Find("ouR");
		GameObject heishiL = GameObject.Find("heishiL");
		GameObject heishiR = GameObject.Find("heishiR");
		GameObject teshitaL = GameObject.Find("teshitaL");
		GameObject teshitaR = GameObject.Find("teshitaR");
		GameObject back1 = GameObject.Find("back1");
		Image IhimeL, IhimeR, ImaouL, ImaouR, IouL, IouR, IheishiL, IheishiR, IteshitaL, IteshitaR, Iback1;

        IhimeL = himeL.GetComponent<Image>();
		IhimeR = himeR.GetComponent<Image>();
		ImaouL = maouL.GetComponent<Image>();
		ImaouR = maouR.GetComponent<Image>();
		IouL = ouL.GetComponent<Image>();
		IouR = ouR.GetComponent<Image>();
		IheishiL = heishiL.GetComponent<Image>();
		IheishiR = heishiR.GetComponent<Image>();
		IteshitaL = teshitaL.GetComponent<Image>();
		IteshitaR = teshitaR.GetComponent<Image>();
		Iback1 = back1.GetComponent<Image>();

        string left = command["left"];
		string right =  command["right"];
		string back = command["back"];


		if(left == "hime"){
			IhimeL.enabled = true;
			ImaouL.enabled = false;
			IouL.enabled = false;
			IheishiL.enabled = false;
			IteshitaL.enabled = false;
		}
		else if(left == "maou"){
			IhimeL.enabled = false;
			ImaouL.enabled = true;
			IouL.enabled = false;
			IheishiL.enabled = false;
			IteshitaL.enabled = false;
		}
		else if(left == "ou"){
			IhimeL.enabled = false;
			ImaouL.enabled = false;
			IouL.enabled = true;
			IheishiL.enabled = false;
			IteshitaL.enabled = false;
		}
		else if(left == "heishi"){
			IhimeL.enabled = false;
			ImaouL.enabled = false;
			IouL.enabled = false;
			IheishiL.enabled = true;
			IteshitaL.enabled = false;
		}
		else if(left == "teshita"){
			IhimeL.enabled = false;
			ImaouL.enabled = false;
			IouL.enabled = false;
			IheishiL.enabled = false;
			IteshitaL.enabled = true;
		}
		else if(left == "null"){
			IhimeL.enabled = false;
			ImaouL.enabled = false;
			IouL.enabled = false;
			IheishiL.enabled = false;
			IteshitaL.enabled = false;
		}

		if(right == "hime"){
			IhimeR.enabled = true;
			ImaouR.enabled = false;
			IouR.enabled = false;
			IheishiR.enabled = false;
			IteshitaR.enabled = false;
		}
		else if(right == "maou"){
			IhimeR.enabled = false;
			ImaouR.enabled = true;
			IouR.enabled = false;
			IheishiR.enabled = false;
			IteshitaR.enabled = false;
		}
		else if(right == "ou"){
			IhimeR.enabled = false;
			ImaouR.enabled = false;
			IouR.enabled = false;
			IheishiR.enabled = false;
			IteshitaR.enabled = false;
		}
		else if(right == "heishi"){
			IhimeR.enabled = false;
			ImaouR.enabled = false;
			IouR.enabled = false;
			IheishiR.enabled = true;
			IteshitaR.enabled = false;
		}
		else if(right == "teshita"){
			IhimeR.enabled = false;
			ImaouR.enabled = false;
			IouR.enabled = false;
			IheishiR.enabled = false;
			IteshitaR.enabled = true;
		}
		else if(right == "null"){
			IhimeR.enabled = false;
			ImaouR.enabled = false;
			IouR.enabled = false;
			IheishiR.enabled = false;
			IteshitaR.enabled = false;
		}

		if(back == "1"){ 
			Iback1.enabled = true;
		}
		else if(back == "null"){
			Iback1.enabled = false;
		}

/*if(hit == "hime"){
			if(pos == "hidari"){
				IhimeL.enabled = true;
			}
			else if(pos == "migi"){
				IhimeR.enabled = true;
			}
			else if(pos == "delete"){
				IhimeL.enabled = false;
				IhimeR.enabled = false;
			}
		}else if(hit == "maou"){
			if(pos == "hidari"){
				ImaouL.enabled = true;
			}
			else if(pos == "migi"){
				ImaouR.enabled = true;
			}
			else if(pos == "delete"){
				ImaouL.enabled = false;
				ImaouR.enabled = false;
			}
		}if(hit == "heisi"){
			if(pos == "hidari"){
				IheisiBL.enabled = true;
			}
			else if(pos == "migi"){
				IheisiBR.enabled = true;
			}
			else if(pos == "delete"){
				IheisiBL.enabled = false;
				IheisiBR.enabled = false;
			}
		}
		
		/*if(pos == "true")
			image.enabled = true;
		else if(pos == "false")
			image.enabled = false;
		else if(pos == "Etrue")
			imageE.enabled = true;
		else if(pos == "Efalse")
			imageE.enabled = false;
		else if(pos == "Ttrue")
			imageT.enabled = true;
		else if(pos == "Tfalse")
			imageT.enabled = false;
		else if(pos == "Ctrue")
			imageC.enabled = true;
		else if(pos == "Cfalse")
			imageC.enabled = false;*/
	}
	
}
