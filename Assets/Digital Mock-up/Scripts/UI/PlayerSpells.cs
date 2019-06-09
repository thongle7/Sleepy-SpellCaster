using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpells : MonoBehaviour {

   // public float lullabyQuant;
    //public float blanketQuant;
    //public float drainQuant;
    //public float warmMilkQuant;
    //public float eternalSleepQuant;


    public Text lullabyCount;
    public Text blanketCount;
    public Text drainCount;
    public Text warmMilkCount;
    public Text eternalSleepCount;

	
	// Update is called once per frame
	void Update () {
        lullabyCount.text = wiz_control.lullabyStock.ToString();
        blanketCount.text = wiz_control.blanketStock.ToString();
        drainCount.text = wiz_control.drainStock.ToString();
        warmMilkCount.text = wiz_control.warmMilkStock.ToString();
        eternalSleepCount.text = wiz_control.eternalSleepStock.ToString();

	}
}
