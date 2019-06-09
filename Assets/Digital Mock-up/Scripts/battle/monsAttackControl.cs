using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsAttackControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector2(-5, 0);
        Destroy(gameObject, 1.5f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
