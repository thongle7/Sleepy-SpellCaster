using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mons_sleepScript : MonoBehaviour {

    public mon_control monster;
    public float speed;
    public float smoothing;

    private float startWidth;
    private float startHeight;
    private float velocity;

    //private float of moving value
    private float fakeSleep;


    // Use this for initialization
    void Start()
    {
        Vector2 cur = GetComponent<RectTransform>().sizeDelta;
        startWidth = cur.x;
        startHeight = cur.y;
        fakeSleep = monster.monsFatigue;
    }

    // Update is called once per frame
    void Update()
    {
        fakeSleep = Mathf.SmoothDamp(fakeSleep, monster.monsFatigue, ref velocity, smoothing, speed, Time.deltaTime);
        //float result = playerSleep.sleep / playerSleep.maxSleep * startWidth;
        float fResult = fakeSleep / mon_control.monsMaxFatigue * startWidth;
        //GetComponent<RectTransform>().sizeDelta = new Vector2(result, startHeight);
        //Vector2 newPos = new Vector2(result, startHeight);
        GetComponent<RectTransform>().sizeDelta = new Vector2(fResult, startHeight);
    }
}
