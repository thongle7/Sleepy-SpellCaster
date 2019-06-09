using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteAfterDelay : MonoBehaviour {

    private float flightTime = 2f;
    private float ReturnTime = 0f;

    // Use this for initialization
    void Start () {
        ReturnTime = Time.time + flightTime;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= ReturnTime)
        {
            Destroy(this.gameObject);
        }
    }
}
