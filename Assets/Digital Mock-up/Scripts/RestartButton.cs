using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RestartButton : MonoBehaviour
{

    public Button runButton;
    private int curLS;
    private int curWMS;
    private int curBS;
    private int curDS;
    private int curESS;

    // Use this for initialization
    void Start()
    {
        runButton.onClick.AddListener(TaskOnClick);
        curLS = wiz_control.lullabyStock;
        curWMS = wiz_control.warmMilkStock;
        curBS = wiz_control.blanketStock;
        curDS = wiz_control.drainStock;
        curESS = wiz_control.eternalSleepStock;

}

    void TaskOnClick()
    {
        wiz_control.lullabyStock = curLS;
        wiz_control.warmMilkStock = curWMS;
        wiz_control.blanketStock = curBS;
        wiz_control.drainStock = curDS;
        wiz_control.eternalSleepStock = curESS;
        wiz_control.wizFatigue = 0;
        GameTime.isPaused = false;
        SceneManager.LoadScene(PlayerSleep.curScene);
    }
}
