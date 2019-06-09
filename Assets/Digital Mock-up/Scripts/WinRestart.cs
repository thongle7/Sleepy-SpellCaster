using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinRestart : MonoBehaviour
{

    public Button runButton;

    // Use this for initialization
    void Start()
    {
        runButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        wiz_control.lullabyStock = 0;
        wiz_control.warmMilkStock = 0;
        wiz_control.blanketStock = 0;
        wiz_control.drainStock = 0;
        wiz_control.eternalSleepStock = 0;
        wiz_control.wizFatigue = 0;
        GameTime.isPaused = false;
        SceneManager.LoadScene("Menu");
    }
}
