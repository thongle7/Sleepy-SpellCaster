﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealTextCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingOrder = 10;
        GetComponent<TextMesh>().text = "30";
        Destroy(gameObject, 1.5f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
