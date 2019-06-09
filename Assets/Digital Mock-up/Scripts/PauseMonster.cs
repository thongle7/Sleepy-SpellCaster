using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMonster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameTime.isPaused){
            Vector3 p = transform.position;
            p.z = 10;
            transform.position = p;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().isKinematic = true;
            
        }
        else{
            GetComponent<Rigidbody2D>().isKinematic = false;
            Vector3 p = transform.position;
            p.z = 0;
            transform.position = p;
        }
        
	}
}
