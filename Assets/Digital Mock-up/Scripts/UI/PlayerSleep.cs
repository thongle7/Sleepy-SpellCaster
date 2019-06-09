using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSleep : MonoBehaviour
{

    public float sleep;

    public float maxSleep;

    public Text sleepText;

    public static string curScene;

    public AudioSource music;

    void Start()
    {
        curScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        sleepText.text = wiz_control.wizFatigue.ToString();
        //have player die
        if(wiz_control.wizFatigue > maxSleep)
        {
            wiz_control.wizFatigue = maxSleep;
            SceneManager.LoadScene("Gameover");
        }
        if (wiz_control.wizFatigue == maxSleep)
        {
            SceneManager.LoadScene("Gameover");
        }
        if (wiz_control.wizFatigue < 0)
        {
            wiz_control.wizFatigue = 0;
        }

        //Set audio pitch
        if (wiz_control.wizFatigue < 20)
        {
            music.pitch = 1;
        }
        if (wiz_control.wizFatigue > 20)
        {
            music.pitch = .95f;
        }
        if (wiz_control.wizFatigue > 40)
        {
            music.pitch = .9f;
        }
        if (wiz_control.wizFatigue > 60)
        {
            music.pitch = .85f;
        }
        if (wiz_control.wizFatigue > 80)
        {
            music.pitch = .8f;
        }
        if (wiz_control.wizFatigue > 90)
        {
            music.pitch = .75f;
        }
    }
}
