using UnityEngine;
using System.Collections;

public class system : MonoBehaviour
{
    static public int stageNum;
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
    }
    public void numSelect2()
    {
        stageNum = 2;
    }
    public void numSelect3()
    {
        stageNum = 3;
    }
    public void numSelect4()
    {
        stageNum = 4;
    }
    public void numSelect5()
    {
        stageNum = 5;
    }
    public void numSelect6()
    {
        stageNum = 6;
    }
    public void numSelect7()
    {
        stageNum = 7;
    }
    public void numSelect8()
    {
        stageNum = 8;
    }
    public void numSelect9()
    {
        stageNum = 9;
    }
    public void numSelect10()
    {
        stageNum = 10;
    }
    public void numSelect11()
    {
        stageNum = 11;
    }
    public void numSelect12()
    {
        stageNum = 12;
    }
    public void numSelect13()
    {
        stageNum = 13;
    }
    public void numSelect14()
    {
        stageNum = 14;
    }
    public void numSelect15()
    {
        stageNum = 15;
    }
    public void numSelect16()
    {
        stageNum = 16;
    }
    public void numSelect17()
    {
        stageNum = 17;
    }
    public void numSelect18()
    {
        stageNum = 18;
    }
    public void numSelect19()
    {
        stageNum = 19;
    }
    public void numSelect20()
    {
        stageNum = 20;
    }
}
