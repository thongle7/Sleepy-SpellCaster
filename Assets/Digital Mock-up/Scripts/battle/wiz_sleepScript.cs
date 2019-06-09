using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wiz_sleepScript : MonoBehaviour {

    public float speed;
    public float smoothing;

    private float startWidth;
    private float startHeight;
    private float velocity;

    //private float of moving value
    private float fakeSleep;

    private Vector2 cur;

    // Use this for initialization
    void Start()
    {
        cur = GetComponent<RectTransform>().sizeDelta;
        startWidth = cur.x;
        startHeight = cur.y;
        fakeSleep = wiz_control.wizFatigue;
    }

    // Update is called once per frame
    void Update()
    {
        fakeSleep = Mathf.SmoothDamp(fakeSleep, wiz_control.wizFatigue, ref velocity, smoothing, speed, Time.deltaTime);
        //float result = playerSleep.sleep / playerSleep.maxSleep * startWidth;
        float fResult = fakeSleep / wiz_control.wizMaxFatigue * startWidth;
        //GetComponent<RectTransform>().sizeDelta = new Vector2(result, startHeight);
        //Vector2 newPos = new Vector2(result, startHeight);
        GetComponent<RectTransform>().sizeDelta = new Vector2(fResult, startHeight);
    }
}
