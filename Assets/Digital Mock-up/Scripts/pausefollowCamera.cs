﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausefollowCamera : MonoBehaviour
{

    private GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("WizSprite");
        Vector3 p = player.transform.position;
        p.z = -10;
        this.transform.position = p;
    }
}
