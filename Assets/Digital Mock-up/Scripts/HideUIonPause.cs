using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUIonPause : MonoBehaviour {

    public CanvasGroup main;
	
	// Update is called once per frame
	void Update () {
        if (GameTime.isPaused)
        {
            main.alpha = 0f; //this makes everything transparent
            main.blocksRaycasts = false; //this prevents the UI element to receive input events

        }
        else
        {
            main.alpha = 1f;
            main.blocksRaycasts = true;
        }
    }
}
