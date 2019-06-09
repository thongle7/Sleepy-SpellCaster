using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField]
    private Stat sleep;

	
	private void Awake ()
    {
        sleep.Initialize();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    sleep.CurVal -= 10;
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    sleep.CurVal += 10;
        //}
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Plant")
        {
            sleep.CurVal += 1;
        }

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Plant")
        {
            sleep.CurVal++;
        }

    }
}
