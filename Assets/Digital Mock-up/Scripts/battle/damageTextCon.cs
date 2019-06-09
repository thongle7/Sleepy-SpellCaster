using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTextCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingOrder = 10;
        GetComponent<TextMesh>().text = battleFlow.currentDammage.ToString();
        Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
