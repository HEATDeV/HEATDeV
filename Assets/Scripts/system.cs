using UnityEngine;
using System.Collections;

public class system : MonoBehaviour
{
    static public int stageNum;
	static public int stageID;

	static public bool clear1;
	static public bool clear2;
	static public bool clear3;
	static public bool clear4;
	static public bool clear5;
	static public bool clear6;
	static public bool clear7;
	static public bool clear8;
	static public bool clear9;
	static public bool clear10;
	static public bool clear11;
	static public bool clear12;
	static public bool clear13;
	static public bool clear14;
	static public bool clear15;
	static public bool clear16;
	static public bool clear17;
	static public bool clear18;
	static public bool clear19;
	static public bool clear20;

	int clearNum;
    void Start()
    {
        stageNum = PlayerPrefs.GetInt("stageNum");
        clearNum = PlayerPrefs.GetInt("clearNum");
    }

    void Update()
    {
        DontDestroyOnLoad(this);
        PlayerPrefs.SetInt("stageNum", stageNum);
        PlayerPrefs.SetInt("clearNum", clearNum);
        PlayerPrefs.Save();
    }

    public void numSelect1() {
        stageNum = 1;
		stageID = 1;
    }
    public void numSelect2()
    {
        stageNum = 2;
		stageID = 1;
	}
    public void numSelect3()
    {
        stageNum = 3;
		stageID = 2;
	}
    public void numSelect4()
    {
        stageNum = 4;
		stageID = 1;
	}
    public void numSelect5()
    {
        stageNum = 5;
		stageID = 3;
	}
    public void numSelect6()
    {
        stageNum = 6;
		stageID = 1;
	}
    public void numSelect7()
    {
        stageNum = 7;
		stageID = 1;
	}
    public void numSelect8()
    {
        stageNum = 8;
		stageID = 2;
	}
    public void numSelect9()
    {
        stageNum = 9;
		stageID = 1;
	}
    public void numSelect10()
    {
        stageNum = 10;
		stageID = 3;
	}
    public void numSelect11()
    {
        stageNum = 11;
		stageID = 3;
	}
    public void numSelect12()
    {
        stageNum = 12;
		stageID = 1;
	}
    public void numSelect13()
    {
        stageNum = 13;
		stageID = 2;
	}
    public void numSelect14()
    {
        stageNum = 14;
		stageID = 3;
	}
    public void numSelect15()
    {
        stageNum = 15;
		stageID = 1;
	}
    public void numSelect16()
    {
        stageNum = 16;
		stageID = 2;
	}
    public void numSelect17()
    {
        stageNum = 17;
		stageID = 3;
    }
    public void numSelect18()
    {
        stageNum = 18;
		stageID = 1;
	}
    public void numSelect19()
    {
        stageNum = 19;
		stageID = 2;
	}
    public void numSelect20()
    {
        stageNum = 20;
		stageID = 4;
	}
}
